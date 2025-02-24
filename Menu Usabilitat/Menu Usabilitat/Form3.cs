using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form3 : Form
    {
        public UserBase? User { get; set; }
        public UserType UserType { get; set; }

        public Form3(UserBase? user = null)
        {
            User = user;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxUserType.DataSource = Enum.GetValues(typeof(UserType));

            if (User == null)
            {
                this.Text = "Create New User";
                textBoxId.Text = UsersRepository.GetInstance().GetNextUserId().ToString();
                buttonSave.Text = "Create";
                buttonDelete.Enabled = false;
            }
            else
            {
                this.Text = $"Update User - {User.Name} (id: {User.Id})";
                textBoxId.Text = User.Id.ToString();
                textBoxName.Text = User.Name;
                textBoxMail.Text = User.Mail;
                comboBoxUserType.SelectedItem = User.GetUserType();
                comboBoxUserType.Enabled = true;
                buttonSave.Text = "Update";

                SetCustomDataLabels(User.GetUserType());

                if (User.GetUserType() == UserType.Student)
                {
                    Student s = (Student)User;

                    textBoxCustomData.Text = s.Course;
                }
                else
                {
                    textBoxCustomData.Text = ((Admin)User).Department;
                }

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SetCustomDataLabels(UserType userType)
        {
            if (userType == UserType.Student)
            {
                labelCustomData.Text = "Course:";
            }
            else
            {
                labelCustomData.Text = "Department:";
            }
        }

    }
}
