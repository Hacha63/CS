namespace Menu_Usabilitat
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            textBoxMail = new TextBox();
            textBoxCustomData = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelCustomData = new Label();
            comboBoxUserType = new ComboBox();
            label5 = new Label();
            buttonDelete = new Button();
            buttonSave = new Button();
            groupBox1 = new GroupBox();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(67, 42);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(67, 84);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(67, 125);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(100, 23);
            textBoxMail.TabIndex = 2;
            // 
            // textBoxCustomData
            // 
            textBoxCustomData.Location = new Point(69, 27);
            textBoxCustomData.Name = "textBoxCustomData";
            textBoxCustomData.Size = new Size(100, 23);
            textBoxCustomData.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 45);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 128);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Mail";
            // 
            // labelCustomData
            // 
            labelCustomData.AutoSize = true;
            labelCustomData.Location = new Point(14, 30);
            labelCustomData.Name = "labelCustomData";
            labelCustomData.Size = new Size(49, 15);
            labelCustomData.TabIndex = 7;
            labelCustomData.Text = "Custom";
            // 
            // comboBoxUserType
            // 
            comboBoxUserType.FormattingEnabled = true;
            comboBoxUserType.Location = new Point(242, 42);
            comboBoxUserType.Name = "comboBoxUserType";
            comboBoxUserType.Size = new Size(121, 23);
            comboBoxUserType.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 45);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "Type";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(67, 251);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(205, 251);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelCustomData);
            groupBox1.Controls.Add(textBoxCustomData);
            groupBox1.Location = new Point(36, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 60);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(339, 251);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 286);
            Controls.Add(buttonCancel);
            Controls.Add(groupBox1);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(label5);
            Controls.Add(comboBoxUserType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxMail;
        private TextBox textBoxCustomData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelCustomData;
        private ComboBox comboBoxUserType;
        private Label label5;
        private Button buttonDelete;
        private Button buttonSave;
        private GroupBox groupBox1;
        private Button buttonCancel;
    }
}