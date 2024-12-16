namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x, y;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x + y);
        }

        private void btnlimpliar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresultado.Text = "";
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x - y);
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x * y);
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x / y);
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);

            double resultado = Math.Pow(x, y);
            txtresultado.Text = string.Format("{0:f2}", resultado);
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            double resultado = Math.Sqrt(x);
            txtresultado.Text = string.Format("{0:f2}", resultado);
        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
