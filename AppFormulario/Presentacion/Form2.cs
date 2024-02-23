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


namespace AppFormulario.Presentacion
{
    public partial class Form2 : Form
    {
        private string numeroSolicitud = "";
        private string descripcion = "";
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
        public Form2()
        {
            InitializeComponent();
            ContinuarButton.Enabled = false;
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
                Form form1;
                form1 = new Form2();
                form1.Show();
                this.Close();
            }
            catch (ServiceException) { }
        }
    }
}
