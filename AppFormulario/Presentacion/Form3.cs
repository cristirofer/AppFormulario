using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppFormulario.Presentacion
{
    public partial class Form3 : FormBase
    {

        public int orden = 1;
        public string nombreBeneficiario = "";
        public string NIFBeneficiario = "";
        public string parentescoBeneficiario = "";
        public string porcentajeBeneficiario = "";

        public Form3()
        {
            InitializeComponent();
            AñadirButton.Enabled = false;
            EliminarButton.Enabled = false;
            GenerarButton.Enabled = true;
            NIFLabel.Visible = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            try
            {
                //FormBase form2;
                //form2 = new Form2();
                //form2.ShowDialog();
                this.Close();
            }
            catch (ServiceException) { }
        }

        private bool checkAñadirButton()
        {
            bool b = nombreBeneficiario == "" || NIFBeneficiario == "" | parentescoBeneficiario == "" || porcentajeBeneficiario == "";
            if (b) return false;
            else return true;
        }

        private bool checkGenerarButton()
        {
            if (dataGridView1.RowCount == 0) return true;
            else if (ComprobarSumaEnQuintoCampo()) return true;
            else return false;
        }

        private bool ComprobarSumaEnQuintoCampo()
        {
            int sumaTotal = 0;

            // Recorrer cada fila del DataGridView
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Verificar si la fila no está vacía y tiene al menos cinco celdas
                if (!fila.IsNewRow && fila.Cells.Count >= 5)
                {
                    // Intentar convertir el valor de la quinta celda a un número
                    if (int.TryParse(fila.Cells[4].Value.ToString(), out int valorCelda))
                    {
                        // Sumar el valor al total
                        sumaTotal += valorCelda;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (sumaTotal == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombreBeneficiario = NombreBeneficiarioTextBox.Text;
            if (checkAñadirButton())
            {
                AñadirButton.Enabled = true;
            }
            else
            {
                AñadirButton.Enabled = false;
            }
        }

        private void NIFBeneficiarioTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d{8}[A-Za-z]$";
            if (Regex.IsMatch(NIFBeneficiarioTextBox.Text.Trim(), patron))
            {
                NIFLabel.Visible = false;
                NIFBeneficiario = NIFBeneficiarioTextBox.Text;
                if (VerificarDNIUnico(NIFBeneficiarioTextBox.Text.Trim()))
                {
                    if (checkAñadirButton())
                    {
                        AñadirButton.Enabled = true;
                    }
                    else
                    {
                        AñadirButton.Enabled = false;
                    }
                }
                else
                {
                    NIFLabel.Text = "DNI ya existe";
                    NIFLabel.Visible = true;
                }
            }
            else
            {
                NIFLabel.Text = "Formato no válido";
                NIFLabel.Visible = true;
            }
        }

        private bool VerificarDNIUnico(string dni)
        {
            // Iterar a través de todas las filas del DataGridView y verificar si el DNI está presente
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                // Se verifica si la celda de la columna 3 no es nula y si su valor es igual al DNI ingresado
                if (fila.Cells[2].Value != null && fila.Cells[2].Value.ToString() == dni)
                {
                    // Si se encuentra una coincidencia, el DNI no es único
                    return false;
                }
            }
            // Si no se encontraron coincidencias, el DNI es único
            return true;
        }

        private void ParentescoBeneficiarioTextBox_TextChanged(object sender, EventArgs e)
        {
            parentescoBeneficiario = ParentescoBeneficiarioTextBox.Text;
            if (checkAñadirButton())
            {
                AñadirButton.Enabled = true;
            }
            else
            {
                AñadirButton.Enabled = false;
            }
        }

        private void PorcentajeBeneficiarioTextBox_TextChanged(object sender, EventArgs e)
        {
            porcentajeBeneficiario = PorcentajeBeneficiarioTextBox.Text;
            if (checkAñadirButton())
            {
                AñadirButton.Enabled = true;
            }
            else
            {
                AñadirButton.Enabled = false;
            }
        }

        private void AñadirButton_Click(object sender, EventArgs e)
        {
            // Añadir los valores al DataGridView
            dataGridView1.Rows.Add(orden, nombreBeneficiario, NIFBeneficiario, parentescoBeneficiario, porcentajeBeneficiario);
            orden++;

            // Limpiar los TextBox después de añadir los valores
            LimpiarTextBoxes();
            if (checkGenerarButton())
            {
                GenerarButton.Enabled = true;
            }
            else
            {
                GenerarButton.Enabled = false;
            }
        }

        private void LimpiarTextBoxes()
        {
            // Limpiar todos los TextBox en el formulario
            NombreBeneficiarioTextBox.Clear();
            NIFBeneficiarioTextBox.Clear();
            ParentescoBeneficiarioTextBox.Clear();
            PorcentajeBeneficiarioTextBox.Clear();

            nombreBeneficiario = "";
            NIFBeneficiario = "";
            parentescoBeneficiario = "";
            porcentajeBeneficiario = "";

            NIFLabel.Visible = false;
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormBase form4;
                form4 = new Form4();
                form4.ShowDialog();
                //this.Close();
            }
            catch (ServiceException) { }
        }

        private void EliminarFila(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    // Eliminar la fila del DataGridView
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            EliminarButton.Enabled = true;
        }
    }
}
