using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Llibreria
{
    public partial class FrmProductes : Form
    {
        private List<Producte> productes = new List<Producte>();

        public FrmProductes()
        {
            InitializeComponent();
            cmbTipus.Items.Add("Físic");
            cmbTipus.Items.Add("Digital");
            cmbTipus.SelectedIndex = 0;
        }

        private void btnAfegir_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtNom.Text;
                decimal preu = decimal.Parse(txtPreu.Text);

                if (string.IsNullOrWhiteSpace(nom))
                {
                    throw new Exception("El nom del producte no pot estar buit.");
                }

                Producte producte;
                if (cmbTipus.SelectedItem.ToString() == "Físic")
                {
                    float pes = float.Parse(txtExtra.Text);
                    producte = new ProducteFisic(nom, preu, pes);
                }
                else
                {
                    string format = txtExtra.Text;
                    producte = new ProducteDigital(nom, preu, format);
                }

                productes.Add(producte);
                lstProductes.Items.Add(nom);
                MessageBox.Show("Producte afegit correctament!");

                // Netejar camps
                txtNom.Clear();
                txtPreu.Clear();
                txtExtra.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("El preu i el camp extra han de ser números vàlids (per productes físics).");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDetalls_Click(object sender, EventArgs e)
        {
            if (lstProductes.SelectedIndex != -1)
            {
                Producte producteSeleccionat = productes[lstProductes.SelectedIndex];
                FrmDetallsProducte frmDetalls = new FrmDetallsProducte(producteSeleccionat);
                frmDetalls.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un producte de la llista.");
            }
        }
    }
}
