using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenC_
{
    public partial class FrmDetallsEstudiant : Form
    {
        //importo datos del formulario1
        public int index1;
        public FrmExamen form;


        public FrmDetallsEstudiant(Estudiant estudiant, int index, FrmExamen form1)
        {

            InitializeComponent();

            //Creo mis variables para posteriormente eliminar el estudiante correcto
            index1 = index;
            form = form1;

            //pongo los numero como string para poder hacer display en textbox
            string edat1 = estudiant.Edat.ToString();
            string nota1 = estudiant.Nota.ToString();

            //pongo la informacion a los textbox
            txtNom.Text = estudiant.Nom;
            txtEdat.Text = edat1;
            txtNota.Text = nota1;
            txtClasse.Text = estudiant.Classe;
            //si es ordinari tendra siempre el mismo comentario si no, el que se ha añadido
            if (estudiant is EstudiantExcel_lent)
            {
                txtMerit.Text = estudiant.Merit;
            }
            else 
            {
                txtMerit.Text = ("Estudiant Ordinari");
            }

        }


        //cierra el formulario
        private void btnTancar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetallsEstudiant_Load(object sender, EventArgs e)
        {

        }
        //Este boton no guarda, lo he modificado para borrar desde el segundo formulario y se cierra
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            form.estudiants.RemoveAt(index1);
            form.Eliminar();
            this.Close();


        }
    }
}
