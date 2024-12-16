namespace Gestió_d_una_biblioteca
{
    partial class Form2
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
            lbnom = new Label();
            lbtipus = new Label();
            btntancar = new Button();
            btneliminar = new Button();
            SuspendLayout();
            // 
            // lbnom
            // 
            lbnom.AutoSize = true;
            lbnom.Location = new Point(299, 124);
            lbnom.Name = "lbnom";
            lbnom.Size = new Size(34, 15);
            lbnom.TabIndex = 0;
            lbnom.Text = "Nom";
            lbnom.Click += lbnom_Click;
            // 
            // lbtipus
            // 
            lbtipus.AutoSize = true;
            lbtipus.Location = new Point(373, 124);
            lbtipus.Name = "lbtipus";
            lbtipus.Size = new Size(35, 15);
            lbtipus.TabIndex = 1;
            lbtipus.Text = "Tipus";
            // 
            // btntancar
            // 
            btntancar.Location = new Point(326, 195);
            btntancar.Name = "btntancar";
            btntancar.Size = new Size(75, 23);
            btntancar.TabIndex = 2;
            btntancar.Text = "Tancar";
            btntancar.UseVisualStyleBackColor = true;
            btntancar.Click += btntancar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(407, 195);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 23);
            btneliminar.TabIndex = 3;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btneliminar);
            Controls.Add(btntancar);
            Controls.Add(lbtipus);
            Controls.Add(lbnom);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbnom;
        private Label lbtipus;
        private Button btntancar;
        private Button btneliminar;
    }
}