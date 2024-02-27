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
            numeroSolicitud = NumSolicitudTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
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
            fechaInicio = InicioTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void FinTextBox_TextChanged(object sender, EventArgs e)
        {
            fechaFin = FinTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
        }

        private void BolsaTextBox_TextChanged(object sender, EventArgs e)
        {
            bolsa = BolsaTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
            }
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
            DNITutorUPV = DNITutorTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
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
            DNITutorEmpresa = DNITutor2TextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
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
            DNIResponsable = DNIResponsableTextBox.Text;
            if (checkButton())
            {
                ContinuarButton.Enabled = true;
            }
            else
            {
                ContinuarButton.Enabled = false;
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
