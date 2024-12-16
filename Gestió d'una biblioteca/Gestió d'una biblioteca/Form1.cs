namespace Gestió_d_una_biblioteca
{
    using System.IO;
    using System.Text.Json;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbTipus.Items.Add("Digital");
            cmbTipus.Items.Add("Paper");
            cmbTipus.SelectedIndex = 0;


        }
        public List<Llibre> llibres = new List<Llibre>();





        private void btnAfegir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitol.Text) ||
             string.IsNullOrWhiteSpace(txtAutor.Text) ||
             string.IsNullOrWhiteSpace(txtAny.Text) ||
             string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Omple tots els camps", "Error");
                return;
            }

            if (!int.TryParse(txtAny.Text, out int any))
            {
                MessageBox.Show("Ha de ser un numero", "Error");
                return;
            }

            Llibre llibre;
            if (cmbTipus.SelectedItem.ToString() == "Digital")
            {
                llibre = new LlibreDigital(txtTitol.Text, txtAutor.Text, int.Parse(txtAny.Text), txtISBN.Text);
            }
            else
            {
                llibre = new LlibrePaper(txtTitol.Text, txtAutor.Text, int.Parse(txtAny.Text), txtISBN.Text);
            }

            llibres.Add(llibre);
            lstLlibres.Items.Add(llibre.Titol);

            txtTitol.Clear();
            txtAutor.Clear();
            txtAny.Clear();
            txtISBN.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (lstLlibres.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un llibre.", "Error");
                return;
            }
            Llibre llibreSeleccionat = llibres[lstLlibres.SelectedIndex];
            //MessageBox.Show(llibreSeleccionat.MostrarInformacio(), "Detalls del llibre");//
            Form2 form2 = new Form2(llibreSeleccionat, lstLlibres.SelectedIndex, this);
            form2.ShowDialog();

        }

        private void cmbTipus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstLlibres.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un llibre", "Error");
                return;
            }

            Llibre llibreSeleccionat = llibres[lstLlibres.SelectedIndex];

            txtTitol.Text = llibreSeleccionat.Titol;
            txtAutor.Text = llibreSeleccionat.Autor;
            txtAny.Text = llibreSeleccionat.Any.ToString();
            txtISBN.Text = llibreSeleccionat.ISBN;

            if (llibreSeleccionat is LlibreDigital)
                cmbTipus.SelectedItem = "Digital";
            else if (llibreSeleccionat is LlibrePaper)
                cmbTipus.SelectedItem = "Paper";

            llibres.RemoveAt(lstLlibres.SelectedIndex);
            lstLlibres.Items.RemoveAt(lstLlibres.SelectedIndex);
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            if (lstLlibres.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un llibre per eliminar.", "Error");
                return;
            }

            DialogResult resultat = MessageBox.Show("Segur que vols eliminar aquest llibre?", "Confirmació", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                llibres.RemoveAt(lstLlibres.SelectedIndex);
                lstLlibres.Items.RemoveAt(lstLlibres.SelectedIndex);
                MessageBox.Show("Llibre eliminat correctament.", "Èxit");
            }
        }

        public void Eliminar()
        {
            lstLlibres.Items.RemoveAt(lstLlibres.SelectedIndex);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(llibres);

                File.WriteAllText("llibres.json", json);

                MessageBox.Show("Llibres guardats", "Correcte");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar els llibres: {ex.Message}", "Error");
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("llibres.json"))
                {
                    MessageBox.Show("llibres.json no existeix", "Error");
                    return;
                }

                string json = File.ReadAllText("llibres.json");
                llibres = JsonSerializer.Deserialize<List<Llibre>>(json);

                lstLlibres.Items.Clear();
                foreach (var llibre in llibres)
                {
                    lstLlibres.Items.Add(llibre.Titol);
                }

                MessageBox.Show("Llibres carregats", "Correcte");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al carregar els llibres: {ex.Message}", "Error");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Esto es un libro, impresionante cirto?");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtTitol_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstLlibres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}



