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
    public partial class FrmExamen : Form
    {
        //lista de estudiantes, publica para verla en el FrmDetallsEstudiants
        public List<Estudiant> estudiants = new List<Estudiant>();

        public FrmExamen()
        {

            InitializeComponent();

            //contenido de classe
            cmbClasse.Items.Add("Matemàtiques");
            cmbClasse.Items.Add("Història");
            cmbClasse.Items.Add("Ciències");
            cmbClasse.SelectedIndex = 0;

            //contenido de tipos
            cmbTipus.Items.Add("Ordinari");
            cmbTipus.Items.Add("Excel·lent");
            cmbTipus.SelectedIndex = 0;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAfegir_Click(object sender, EventArgs e)
        {
            //Try para el control de errores
            try 
            {
                //Recojo los datos, alguno lo he de pasar al tipo de variable correcto
                string nom = txtNom.Text;
                int edat = int.Parse(txtEdat.Text);
                double nota = double.Parse(txtNota.Text);
                string classe = cmbClasse.Text;
                string merit = txtMèrit.Text;

                //Comprobar si hay campos vacios o incorrectos
                if (string.IsNullOrWhiteSpace(nom)) 
                {
                    throw new Exception("El campo Nom esta incompleto");
                }
                if (string.IsNullOrWhiteSpace(classe))
                {
                    throw new Exception("El campo Classe esta incompleto");
                }

                if (edat == null || edat < 16 || edat > 100)
                {
                    throw new Exception("La edad es incorrecta. De 16-100");
                }

                if (nota == null || nota < 0 || nota > 10)
                {
                    throw new Exception("La nota es incorrecta. De 0-10");
                }


                Estudiant estudiant;

                if (cmbTipus.SelectedItem.ToString() == "Ordinari") 
                {
                    estudiant = new EstudiantOrdinari(nom, edat, nota, classe, merit);
                }
                else 
                {
                    estudiant = new EstudiantExcel_lent(nom, edat, nota, classe, merit);
                }

                //añadir a la lista y al listbox
                estudiants.Add(estudiant);
                lstEstudiants.Items.Add(nom);
                MessageBox.Show("Estudiant afegit");

                //limpiar
                txtNom.Clear();
                txtEdat.Clear();
                txtNota.Clear();
                txtMèrit.Clear();

            }
            //catch errores por si alguien pone 
            catch (FormatException)
            {
                MessageBox.Show("El camp Edat i Nota han de ser numeros correctes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de dades: {ex.Message}");
            }
        }
        //boton eliminar con confirmacion
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstEstudiants.SelectedIndex == -1) 
            {
                MessageBox.Show("Seleccina un estudiant per eliminar");
                return;
            }
            DialogResult resultat = MessageBox.Show("Segur?", "Confirmació", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes) 
            {
                estudiants.RemoveAt(lstEstudiants.SelectedIndex);
                lstEstudiants.Items.RemoveAt(lstEstudiants.SelectedIndex);
                MessageBox.Show("Estudiant eliminat");
            }
        }
        //mostrar segundo formulario con datos del estudiante seleccionado
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (lstEstudiants.SelectedIndex == -1) 
            {
                MessageBox.Show("Seleccioa un estudiant primer");
                return;
            }

            Estudiant estudiantseleccionat = estudiants[lstEstudiants.SelectedIndex];
            FrmDetallsEstudiant frmDetallsEstudiant = new FrmDetallsEstudiant(estudiantseleccionat, lstEstudiants.SelectedIndex, this);
            frmDetallsEstudiant.ShowDialog();
        }

        public void Eliminar()
        {
            lstEstudiants.Items.RemoveAt(lstEstudiants.SelectedIndex);
        }
    }
}
