using PracticaEvaluable2;

namespace Menu_Usabilitat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitUsersData();
            LoadListBoxes();


            UsersRepository userrepository = UsersRepository.GetInstance();




            Text = "Menu Izan Christen";

            MenuStrip menu = new MenuStrip();
            ToolStripMenuItem arxiu = new ToolStripMenuItem("Arxiu");
            ToolStripMenuItem mostrar = new ToolStripMenuItem("Mostrar alumnes");
            ToolStripMenuItem obrir = new ToolStripMenuItem("Obrir Form2");
            ToolStripMenuItem tancar = new ToolStripMenuItem("Tancar");

            obrir.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            mostrar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M;


            arxiu.DropDownItems.Add(obrir);
            arxiu.DropDownItems.Add(mostrar);
            arxiu.DropDownItems.Add(tancar);



            tancar.Click += (s, e) => this.Close();

            Form2 form2 = new Form2();
            obrir.Click += (s, e) => form2.Show();


            menu.Items.Add(arxiu);

            this.Controls.Add(menu);



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void InitUsersData()
        {
            var repository = UsersRepository.GetInstance();
            for (int i = 0; i < 100; i++)
            {
                var name = RandomUserDataGenerator.GetRandomName();
                AddStudent(repository.GetNextUserId(), name, RandomUserDataGenerator.NameToMail(name), RandomUserDataGenerator.NameToCourse(name));
            }

            for (int i = 0; i < 5; i++)
            {
                var name = RandomUserDataGenerator.GetRandomName();
                AddAdmin(repository.GetNextUserId(), name, RandomUserDataGenerator.NameToMail(name), "DAM"); ;
            }
        }

        private void AddStudent(int id, string name, string mail, string course)
        {
            UserBase s = new Student(id, name, mail, course);
            UsersRepository.GetInstance().Add(s);
        }

        private void AddAdmin(int id, string name, string mail, string department)
        {
            UserBase a = new Admin(id, name, mail, department);
            UsersRepository.GetInstance().Add(a);
        }


        private void LoadListBoxes()
        {
            UsersRepository.GetInstance().GetStudents().ForEach(s => listBoxStudents.Items.Add(s.ToString()));
            UsersRepository.GetInstance().GetAdmins().ForEach(s => listBoxAdmins.Items.Add(s.ToString()));
        }
    }

    

}
