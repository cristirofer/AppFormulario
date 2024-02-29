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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;


namespace AppFormulario.Presentacion
{
    public partial class Form2 : FormBase
    {
        public string numeroSolicitud = "";
        public string descripcion = "";
        public string tipo = "Curricular";
        public string fechaInicio = "";
        public string fechaFin = "";
        public string bolsa = "";
        public string clave = "";
        public string nombreTutorUPV = "";
        public string DNITutorUPV = "";
        public string correoTutorUPV = "";
        public string departamentoTutorUPV = "";
        public string nombreTutorEmpresa = "";
        public string DNITutorEmpresa = "";
        public string correoTutorEmpresa = "";
        public string cargoTutorEmpresa = "";
        public string titulacionTutorEmpresa = "";
        public string nombreEntidad = "";
        public string nombreResponsable = "";
        public string DNIResponsable = "";
        public string cargoResponsable = "";

        public Form2()
        {
            InitializeComponent();
            ContinuarButton.Enabled = false;
            numSolLabel.Visible= false;
            fechaInicioLabel.Visible= false;
            fechaFinLabel.Visible= false;
            bolsaLabel.Visible= false;
            claveLabel.Visible= false;
            correoEmpresaLabel.Visible= false;
            correoUPVLabel.Visible= false;
            DNIEmpresaLabel.Visible= false;
            DNIUPVLabel.Visible= false;
            DNIResponsablelabel.Visible= false;
        }
        private bool checkButton()
        {
            bool b = numeroSolicitud == "" || descripcion == "" | tipo == "" || fechaInicio == "" || fechaFin == "" || bolsa == "" || clave == "" || nombreTutorUPV == "" || DNITutorUPV == "" || correoTutorUPV == "" || departamentoTutorUPV == "" || nombreTutorEmpresa == "" || DNITutorEmpresa == "" || correoTutorEmpresa == "" || cargoTutorEmpresa == "" || titulacionTutorEmpresa == "" || nombreEntidad == "" || nombreResponsable == "" || DNIResponsable == "" || DNIResponsable == "";
            if (b) return true;
            else return true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
        }

        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            try
            {
                //FormBase form1;
                //form1 = new Form1();
                //form1.ShowDialog();
                this.Close();
            }
            catch (ServiceException) { }
        }

        private void NumSolicitudTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d{7}$";
            if (Regex.IsMatch(NumSolicitudTextBox.Text.Trim(), patron))
            {
                numeroSolicitud = NumSolicitudTextBox.Text;
                numSolLabel.Visible = false;
                if (checkButton())
                {
                    ContinuarButton.Enabled = true;
                }
                else
                {
                    ContinuarButton.Enabled = false;
                }
            }
            else
            {
                numSolLabel.Visible = true;
            }
        }

        private void DescripcionTextBox_TextChanged(object sender, EventArgs e)
        {
            descripcion = DescripcionTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "No Curricular";
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void InicioTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] formatosFecha = { "dd/MM/yyyy" };
            DateTime fecha;
            if (DateTime.TryParseExact(InicioTextBox.Text.Trim(), formatosFecha, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
            {
                if (fecha.Date >= DateTime.Now.AddDays(15).Date) {
                    fechaInicio = InicioTextBox.Text;
                    fechaInicioLabel.Visible = false;
                    if (checkButton())
                    {
                        ContinuarButton.Enabled = true;
                    }
                    else
                    {
                        ContinuarButton.Enabled = false;
                    }
                }
                else
                {
                    fechaInicioLabel.Text = "Al menos 15 días de antelación";
                    fechaInicioLabel.Visible = true;
                }
            }
            else
            {
                fechaInicioLabel.Text = "Formato no válido";
                fechaInicioLabel.Visible = true;
            }
        }

        private void FinTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] formatosFecha = { "dd/MM/yyyy" };
            DateTime fecha;
            if (DateTime.TryParseExact(FinTextBox.Text.Trim(), formatosFecha, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
            {
                // Convertir la cadena en un objeto DateTime
                DateTime fechaDateTime = DateTime.ParseExact(FinTextBox.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Crear una fecha del 1 de septiembre del mismo año
                DateTime limite = new DateTime(fechaDateTime.Year, 9, 1);

                // Verificar si la fecha es antes o igual al 31 de agosto del mismo año
                if (fechaDateTime < limite)
                {
                    fechaFin = FinTextBox.Text;
                    fechaFinLabel.Visible = false;
                    if (checkButton())
                    {
                        ContinuarButton.Enabled = true;
                    }
                    else
                    {
                        ContinuarButton.Enabled = false;
                    }
                }
                else
                {
                    fechaFinLabel.Text = "Debe ser antes del 1 de Septiembre";
                    fechaFinLabel.Visible = true;
                }
            }
            else
            {
                fechaFinLabel.Text = "Formato no válido";
                fechaFinLabel.Visible = true;
            }
        }

        private void BolsaTextBox_TextChanged(object sender, EventArgs e)
        {
            /*decimal resultado;
            if (decimal.TryParse(BolsaTextBox.Text.Trim(), out resultado))
            {
                decimal valor = decimal.Parse(BolsaTextBox.Text.Trim(), CultureInfo.InvariantCulture);

                // Verificar si el número es mayor o igual a 4,60
                if(decimal.Parse(BolsaTextBox.Text.Trim()) <= 4.60m || valor <= 4.60m)
                {*/
                    bolsa = BolsaTextBox.Text;
                    bolsaLabel.Visible = false;
                    if (checkButton())
                    {
                        ContinuarButton.Enabled = true;
                    }
                    else
                    {
                        ContinuarButton.Enabled = false;
                    }
                /*}
                else
                {
                    bolsaLabel.Text = "Bolsa mínima es 4,60€ ";
                    bolsaLabel.Visible = true;
                }
                
            }
            else
            {
                bolsaLabel.Text = "Formato no válido";
                bolsaLabel.Visible = true;
            }*/
        }

        private void ClaveTextBox_TextChanged(object sender, EventArgs e)
        {
            clave = ClaveTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void NombreTutorTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreTutorUPV = NombreTutorTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void DNITutorTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d{8}[A-Za-z]$";
            if (Regex.IsMatch(DNITutorTextBox.Text.Trim(), patron))
            {
                if (DNITutorEmpresa != DNITutorTextBox.Text && DNIResponsable != DNITutorTextBox.Text)
                {
                    DNITutorUPV = DNITutorTextBox.Text;
                    DNIUPVLabel.Visible = false;
                    if (checkButton())
                    {
                        ContinuarButton.Enabled = true;
                    }
                    else
                    {
                        ContinuarButton.Enabled = false;
                    }
                }
                else
                {
                    DNIUPVLabel.Text = "Tutor UPV no puede ser Tutor o Responsable Empresa";
                    DNIUPVLabel.Visible = true;
                }
            }
            else
            {
                DNIUPVLabel.Text = "Formato no válido";
                DNIUPVLabel.Visible = true;
            }
        }

        private void EmailTutorTextBox_TextChanged(object sender, EventArgs e)
        {
            correoTutorUPV = EmailTutorTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void DepartamentoTutorTextBox_TextChanged(object sender, EventArgs e)
        {
            departamentoTutorUPV = DepartamentoTutorTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void NombreTutor2TextBox_TextChanged(object sender, EventArgs e)
        {
            nombreTutorEmpresa = NombreTutor2TextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void DNITutor2TextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d{8}[A-Za-z]$";
            if (Regex.IsMatch(DNITutor2TextBox.Text.Trim(), patron))
            {
                if (DNITutorUPV != DNITutor2TextBox.Text)
                {
                    DNITutorEmpresa = DNITutor2TextBox.Text;
                    DNIEmpresaLabel.Visible = false;
                    if (checkButton())
                    {
                        ContinuarButton.Enabled = true;
                    }
                    else
                    {
                        ContinuarButton.Enabled = false;
                    }
                }
                else
                {
                    DNIEmpresaLabel.Text = "Tutor UPV no puede ser Tutor o Responsable Empresa";
                    DNIEmpresaLabel.Visible = true;
                }
            }
            else
            {
                DNIEmpresaLabel.Text = "Formato no válido";
                DNIEmpresaLabel.Visible = true;
            }
        }

        private void EmailTutor2TextBox_TextChanged(object sender, EventArgs e)
        {
            correoTutorEmpresa = EmailTutor2TextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void CargoTutor2TextBox_TextChanged(object sender, EventArgs e)
        {
            cargoTutorEmpresa = CargoTutor2TextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void TitulacionTutor2TextBox_TextChanged(object sender, EventArgs e)
        {
            titulacionTutorEmpresa = TitulacionTutor2TextBox.Text;
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
            nombreEntidad = EntidadTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void DNIResponsableTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d{8}[A-Za-z]$";
            if (Regex.IsMatch(DNIResponsableTextBox.Text.Trim(), patron))
            {
                if (DNITutorUPV != DNIResponsableTextBox.Text)
                {
                    DNIResponsable = DNIResponsableTextBox.Text;
                    DNIResponsablelabel.Visible = false;
                    if (checkButton())
                    {
                        ContinuarButton.Enabled = true;
                    }
                    else
                    {
                        ContinuarButton.Enabled = false;
                    }
                }
                else
                {
                    DNIResponsablelabel.Text = "Tutor UPV no puede ser Tutor o Responsable Empresa";
                    DNIResponsablelabel.Visible = true;
                }
            }
            else
            {
                DNIResponsablelabel.Text = "Formato no válido";
                DNIResponsablelabel.Visible = true;
            }
        }

        private void NombreResponsableTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreResponsable = NombreResponsableTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void CargoResponsableTextBox_TextChanged(object sender, EventArgs e)
        {
            cargoResponsable = CargoResponsableTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void ContinuarButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormBase form3;
                form3 = new Form3();
                form3.ShowDialog();
                //this.Close();
            }
            catch (ServiceException) { }
        }
    }
}
