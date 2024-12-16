namespace Descuento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radio0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcantidad.Text = "";
            txttotal.Text = "";
            txtdescuento.Text = "";
            txtprecio.Text = "";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtcantidad.Text);
            double precio = Convert.ToDouble(txtprecio.Text);
            double total = precio * cantidad;

            if (radio0.Checked) {
                txtdescuento.Text = string.Format("{0:f2}", "$0");
                txttotal.Text = string.Format("{0:f2}", "$"+total);
            }
            else if (radio5.Checked) 
            {
                txtdescuento.Text = string.Format("{0:f2}", "$"+(total*0.05));
                txttotal.Text = string.Format("{0:f2}", "$" + (total - (total * 0.05)));
            }
            else if (radio10.Checked)
            {
                txtdescuento.Text = string.Format("{0:f2}", "$" + (total * 0.1));
                txttotal.Text = string.Format("{0:f2}", "$" + (total - (total * 0.1)));
            }
            else if (radio15.Checked)
            {
                txtdescuento.Text = string.Format("{0:f2}", "$" + (total * 0.15));
                txttotal.Text = string.Format("{0:f2}", "$" + (total - (total * 0.15)));
            }
            else if (radio20.Checked)
            {
                txtdescuento.Text = string.Format("{0:f2}", "$" + (total * 0.2));
                txttotal.Text = string.Format("{0:f2}", "$" + (total - (total * 0.2)));
            }

        }
    }
}
