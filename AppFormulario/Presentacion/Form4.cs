using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormulario.Presentacion
{
    public partial class Form4 : FormBase
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
    }
}
