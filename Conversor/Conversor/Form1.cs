namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {

            double dolar = Convert.ToDouble(txtdolar.Text);
            double euro, yen, libra, franco;
            euro = dolar * 0.81;
            yen = dolar * 109.85;
            franco = dolar * 0.95;
            libra = dolar * 0.7;

            txteuro.Text = string.Format("{0:N2}", euro);
            txtyen.Text = string.Format("{0:N2}", yen);
            txtfranc.Text = string.Format("{0:N2}", franco);
            txtlliure.Text = string.Format("{0:N2}", libra);

        }

        private void btnsortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
