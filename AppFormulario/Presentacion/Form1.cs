using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFormulario;
using AppFormulario.Presentacion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace AppFormulario
{
    public partial class Form1 : Form
    {
        private string nombre = "";
        private string DNI = "";
        private string NIF = "";
        private string pais = "";
        private string nacimiento = "";
        private string provincia = "";
        private string municipio = "";
        private string postal = "";
        private string direccion = "";
        private string telefono = "";
        private string email = "";
        private string NUSS = "";
        private string NUSSLetra = "";
        private string titulacion = "";
        private string entidadBanco = "";
        private string agenciaBanco = "";
        private string direccionBanco = "";
        private string municipioBanco = "";
        private string IBAN = "";
        private string CC = "";
        public Form1()
        {
            InitializeComponent();
            ContinuarButton.Enabled = false;
        }

        private bool checkButton()
        {
            bool b = nombre == "" || DNI == "" || NIF == "" || pais == "" || nacimiento == "" || provincia == "" || municipio == "" || postal == "" || direccion == "" || telefono == "" || email == "" || NUSS == "" || NUSSLetra == "" || entidadBanco == "" || agenciaBanco == "" || direccionBanco == "" || municipioBanco == "" || IBAN == "" || CC == "";
            if (b) return false;
            else return true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombre = NombreTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void DNITextBox_TextChanged(object sender, EventArgs e)
        {
            DNI = DNITextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void NIFTextBox_TextChanged(object sender, EventArgs e)
        {
            NIF = NIFTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void NacimientoTextBox_TextChanged(object sender, EventArgs e)
        {
            nacimiento = NacimientoTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void PaisTextBox_TextChanged(object sender, EventArgs e)
        {
            pais = PaisTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void ProvinciaTextBox_TextChanged(object sender, EventArgs e)
        {
            provincia = ProvinciaTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void DireccionTextBox_TextChanged(object sender, EventArgs e)
        {
            direccion = DireccionTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void MunicipioTextBox_TextChanged(object sender, EventArgs e)
        {
            municipio = MunicipioTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void PostalTextBox_TextChanged(object sender, EventArgs e)
        {
            postal = PostalTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void TelefonoTextBox_TextChanged(object sender, EventArgs e)
        {
            telefono = TelefonoTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            email = EmailTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void NumeroAfiliacionTextBox_TextChanged(object sender, EventArgs e)
        {
            NUSS = NumeroAfiliacionTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void LetraAfiliacionTextBox_TextChanged(object sender, EventArgs e)
        {
            NUSSLetra = LetraAfiliacionTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void EntidadTextBox_TextChanged(object sender, EventArgs e)
        {
            entidadBanco = EntidadTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void AgenciaTextBox_TextChanged(object sender, EventArgs e)
        {
            agenciaBanco = AgenciaTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void DireccionAgenciaTextBox_TextChanged(object sender, EventArgs e)
        {
            direccionBanco = DireccionAgenciaTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void MunicipioTextBox2_TextChanged(object sender, EventArgs e)
        {
            municipioBanco = MunicipioTextBox2.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void IBANTextBox_TextChanged(object sender, EventArgs e)
        {
            IBAN = IBANTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void CCTextBox_TextChanged(object sender, EventArgs e)
        {
            CC = CCTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form form2;
                form2 = new Form2();
                form2.Show();
                this.Close();
            }
            catch (ServiceException) { }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContinuarButton_Click2(object sender, MouseEventArgs e)
        {
            try
            {
                Form form2;
                form2 = new Form2();
                form2.Show();
                this.Close();
            }
            catch (ServiceException) { }
        }
    }

}
