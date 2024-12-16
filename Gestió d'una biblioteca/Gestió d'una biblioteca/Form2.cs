using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestió_d_una_biblioteca
{
    public partial class Form2 : Form
    {
        public int index1;

        public Form1 form;

        public Form2(Llibre llibre, int index, Form1 form1)
        {
            InitializeComponent();

            lbnom.Text = $"Nom: {llibre.Titol}";

            if (llibre is LlibreDigital)
            {
                lbtipus.Text = "Tipus: Digital";
            }
            else
            {
                lbtipus.Text = "Tipus: Paper";
            }

            index1 = index;

            form = form1;
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btntancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbnom_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            form.llibres.RemoveAt(index1);
            form.Eliminar();
            this.Close();
        }
    }
}
