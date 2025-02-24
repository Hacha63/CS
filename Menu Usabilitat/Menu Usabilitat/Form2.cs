using PracticaEvaluable2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Usabilitat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void UsersDataGrid_Activated(object sender, DataGridViewCellEventArgs e)
        {
            UsersDataGrid.Rows.Clear();

            UsersRepository.GetInstance().GetAll().ForEach(u => UsersDataGrid.Rows.Add(new string[] { u.Id.ToString(), u.Name, u.Mail }));

        }
        private void UsersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = UsersDataGrid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;

            UserBase? user = UsersRepository.GetInstance().GetById(int.Parse(id.ToString()));
            Form3 editform = new Form3(user);
            editform.ShowDialog();
        }
        private void UsersDataGrid_Load(object sender, DataGridViewCellEventArgs e)
        {
            UsersDataGrid.ColumnCount = 4;
            UsersDataGrid.Columns[0].Name = "ID";
            UsersDataGrid.Columns[1].Name = "Name";
            UsersDataGrid.Columns[2].Name = "Last Name";
            UsersDataGrid.Columns[3].Name = "Type";

            UsersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            UsersRepository.GetInstance().GetAll().ForEach(u => UsersDataGrid.Rows.Add(new string[] { u.Id.ToString(), u.Name, u.Mail }));

            button1.Text = "Add";

            LoadUsersData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 editform = new Form3();
            editform.ShowDialog();

            LoadUsersData();
        }

        private void LoadUsersData()
        {
            UsersDataGrid.Rows.Clear(); // Limpia las filas antes de agregar nuevas

            foreach (var user in UsersRepository.GetInstance().GetAll())
            {
                UsersDataGrid.Rows.Add(user.Id.ToString(), user.Name, user.Mail, user.GetUserType().ToString());
            }
        }


    }
}
