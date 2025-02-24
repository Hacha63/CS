namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadInitialData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfigureDataGridView()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Nom", "Nom");
            dataGridView1.Columns.Add("Edat", "Edat");
            dataGridView1.Columns.Add("Ciutat", "Ciutat");
            dataGridView1.AllowUserToAddRows = false;
        }
        private void LoadInitialData()
        {
            dataGridView1.Rows.Add("1", "Anna", "25", "Barcelona");
            dataGridView1.Rows.Add("2", "Marc", "30", "Girona");
            dataGridView1.Rows.Add("3", "Júlia", "22", "Tarragona");
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("", "", "", "");
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Si us plau, selecciona una fila per eliminar.");
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
