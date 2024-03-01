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
using System.Text.RegularExpressions;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Windows.Forms.VisualStyles;

namespace AppFormulario
{
    public partial class Form1 : FormBase
    {
        public string nombre = "";
        public string DNI = "";
        public string NIE = "";
        public string NIF = "";
        public string pais = "";
        public string nacimiento = "";
        public string provincia = "";
        public string municipio = "";
        public string postal = "";
        public string direccion = "";
        public string telefono = "";
        public string email = "";
        public string NUSS = "";
        public string NUSSLetra = "";
        public string titulacion = "";
        public string entidadBanco = "";
        public string agenciaBanco = "";
        public string direccionBanco = "";
        public string municipioBanco = "";
        public string IBAN = "";
        public string CC = "";
        List<string> titulaciones = new List<string>();
        public string titulacionText = "";

        public Form1()
        {
            InitializeComponent();
            ContinuarButton.Enabled = false;
            emailLabel.Visible = false;
            DNIlabel.Visible = false;
            NIELabel.Visible = false;
            postalLabel.Visible = false;
            fechaLabel.Visible = false;
            telefonoLabel.Visible = false;
            NUSSLabel.Visible = false;
            IBANLabel.Visible = false;
            CCLabel.Visible = false;
            

            string[] opciones = { "G. Ing. Física", "G. Ing. Tecnologías y Servicios de Telecomunicación", "G. Tecnología Digital y Multimedia", "M. Ing. Sistemas Electrónicos", "M. Ing. Telecomunicación", "M. Tecnologías Sistemas y Redes de Comunicación", "DG. ADE + Ing. Tecnologías y Servicios Telecom.", "DG. Matemáticas + ADE", "DG. Matemáticas + Ing. Civil", "DG. Matemáticas + Ing. Informática", "DG. Matemáticas + Ing. Tecn. y Serv. Telecom.", "DM. Ing. Sistemas Electrónicos + Ing. Telecom.", "DM. Ing. Telecom + Ing. Tecn. y Serv. Telecom." };
            titulacionComboBox.Items.AddRange(opciones);
        }

        private bool checkButton()
        {
            bool b = nombre == "" || ((DNI == "" && NIE == "") || (DNI != "" && NIE != "")) || pais == "" || nacimiento == "" || provincia == "" || municipio == "" || postal == "" || direccion == "" || telefono == "" || email == "" || NUSS == "" || NUSSLetra == "" || entidadBanco == "" || agenciaBanco == "" || direccionBanco == "" || municipioBanco == "" || IBAN == "" || CC == "";
            if (b) return true;
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
            string patron = @"^\d{8}$";
            if (Regex.IsMatch(DNITextBox.Text.Trim(), patron))
            {
                DNI = DNITextBox.Text;
                DNIlabel.Visible = false;
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
                DNIlabel.Text = "Formato no válido";
                DNIlabel.Visible = true;
            }

        }
        private void NIFTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d{8}$";
            if (Regex.IsMatch(DNITextBox.Text.Trim(), patron))
            {
                int numeroDNI = int.Parse(DNI);
                string[] letrasNIF = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                int indiceLetra = numeroDNI % 23;
                if (NIFTextBox.Text.Trim() == $"{DNI}{letrasNIF[indiceLetra]}")
                {
                    NIF = NIFTextBox.Text;
                    DNIlabel.Visible = false;
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
                    DNIlabel.Text = "NIF no válido";
                    DNIlabel.Visible = true;
                }
            }
            else
            {
                DNIlabel.Visible = true;
                DNITextBox.Clear();
            }

        }

        private void NIETextBox_TextChanged_1(object sender, EventArgs e)
        {
            string patron = @"^[XYZ]\d{7}[A-Z]$";
            if (Regex.IsMatch(NIETextBox.Text.Trim(), patron))
            {
                NIE = NIETextBox.Text;
                NIELabel.Visible = false;
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
                NIELabel.Text = "Formato no válido";
                NIELabel.Visible = true;
            }
        }

        private void NacimientoTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] formatosFecha = { "dd/MM/yyyy" };
            DateTime fecha;
            if (DateTime.TryParseExact(NacimientoTextBox.Text.Trim(), formatosFecha, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
            {
                nacimiento = NacimientoTextBox.Text;
                fechaLabel.Visible = false;
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
                fechaLabel.Visible = true;
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
            string patron = @"^\d{5}$";
            if (Regex.IsMatch(PostalTextBox.Text.Trim(), patron))
            {
                postal = PostalTextBox.Text;
                postalLabel.Visible = false;
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
                postalLabel.Visible = true;
            }
        }
        private void TelefonoTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d{9}$";
            if (Regex.IsMatch(TelefonoTextBox.Text.Trim(), patron))
            {
                telefono = TelefonoTextBox.Text;
                telefonoLabel.Visible = false;
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
                telefonoLabel.Visible = true;
            }
        }
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(EmailTextBox.Text.Trim(), patron))
            {
                email = EmailTextBox.Text;
                emailLabel.Visible = false;
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
                emailLabel.Visible = true;
                //EmailTextBox.Clear();
            }
        }
        private void NumeroAfiliacionTextBox_TextChanged(object sender, EventArgs e)
        {

            string patron = @"^\d{12}$";
            if (Regex.IsMatch(NumeroAfiliacionTextBox.Text.Trim(), patron))
            {
                NUSS = NumeroAfiliacionTextBox.Text;
                NUSSLabel.Visible = false;
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
                NUSSLabel.Text = "Formato no válido";
                NUSSLabel.Visible = true;
            }
        }
        private void LetraAfiliacionTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d{12}$";
            if (Regex.IsMatch(NumeroAfiliacionTextBox.Text.Trim(), patron))
            {
                if (LetraAfiliacionTextBox.Text == "T")
                {
                    NUSSLetra = LetraAfiliacionTextBox.Text;
                    NUSSLabel.Visible = false;
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
                    NUSSLabel.Text = "Letra no válida";
                    NUSSLabel.Visible = true;
                }
            }
            else
            {
                NumeroAfiliacionTextBox.Clear();
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
            string iban = IBANTextBox.Text.Replace(" ", "").ToUpper();
            string patron = @"^ES\d{22}$";

            // Verificar si el formato del IBAN es correcto mediante expresión regular
            if (!Regex.IsMatch(iban, patron))
            {
                IBAN = IBANTextBox.Text;
                IBANLabel.Visible = false;
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
                IBANLabel.Visible = true;
            }

        }
        private void CCTextBox_TextChanged(object sender, EventArgs e)
        {
            string patron = @"^\d+$";
            if (Regex.IsMatch(CCTextBox.Text.Trim(), patron))
            {

                CC = CCTextBox.Text;
                CCLabel.Visible = false;
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
                CCLabel.Visible = true;
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
                FormBase form2;
                form2 = new Form2();
                form2.ShowDialog();
                //this.Close();
            }
            catch (ServiceException) { }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContinuarButton_Click2(object sender, MouseEventArgs e)
        {


        }

        private void TitulacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titulaciones.Add(titulacionComboBox.SelectedItem.ToString());
            titulacionText+= titulacionComboBox.SelectedItem.ToString();
            titulacionComboBox.Text += titulacionText;


        }
    }

}
