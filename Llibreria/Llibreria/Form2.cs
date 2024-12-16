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
    public partial class FrmDetallsProducte : Form
    {
        private Producte producte;

        public FrmDetallsProducte(Producte producte)
        {
            InitializeComponent();
            this.producte = producte;
            MostrarDetalls();
        }

        private void MostrarDetalls()
        {
            // Labels comuns per a tots els productes
            lblNom.Text = $"Nom: {producte.Nom}";
            lblPreu.Text = $"Preu: {producte.Preu:C}";

            // Labels específics segons el tipus de producte
            if (producte is ProducteFisic producteFisic)
            {
                lblTipus.Text = "Tipus: Físic";
                lblExtra.Text = $"Pes: {producteFisic.Pes} kg";
            }
            else if (producte is ProducteDigital producteDigital)
            {
                lblTipus.Text = "Tipus: Digital";
                lblExtra.Text = $"Format: {producteDigital.Format}";
            }
        }

        private void btnTancar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmDetallsProducte_Load(object sender, EventArgs e)
        {

        }
    }
}
