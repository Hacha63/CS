namespace Menu_Usabilitat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxStudents = new ListBox();
            listBoxAdmins = new ListBox();
            SuspendLayout();
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(66, 44);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(644, 184);
            listBoxStudents.TabIndex = 0;
            listBoxStudents.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBoxAdmins
            // 
            listBoxAdmins.FormattingEnabled = true;
            listBoxAdmins.ItemHeight = 15;
            listBoxAdmins.Location = new Point(66, 234);
            listBoxAdmins.Name = "listBoxAdmins";
            listBoxAdmins.Size = new Size(644, 184);
            listBoxAdmins.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxAdmins);
            Controls.Add(listBoxStudents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxStudents;
        private ListBox listBoxAdmins;
    }
}
