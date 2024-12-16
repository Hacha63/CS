namespace Gestió_d_una_biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbTipus = new ComboBox();
            txtTitol = new TextBox();
            txtAutor = new TextBox();
            txtAny = new TextBox();
            txtISBN = new TextBox();
            btnMostrar = new Button();
            btnAfegir = new Button();
            lstLlibres = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEditar = new Button();
            bntEliminar = new Button();
            btnGuardar = new Button();
            btnCarregar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbTipus
            // 
            cmbTipus.FormattingEnabled = true;
            cmbTipus.Location = new Point(348, 52);
            cmbTipus.Name = "cmbTipus";
            cmbTipus.Size = new Size(92, 23);
            cmbTipus.TabIndex = 0;
            cmbTipus.SelectedIndexChanged += cmbTipus_SelectedIndexChanged;
            // 
            // txtTitol
            // 
            txtTitol.BackColor = SystemColors.Window;
            txtTitol.Location = new Point(6, 52);
            txtTitol.Name = "txtTitol";
            txtTitol.Size = new Size(100, 23);
            txtTitol.TabIndex = 1;
            txtTitol.TextChanged += txtTitol_TextChanged;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(112, 52);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(88, 23);
            txtAutor.TabIndex = 2;
            // 
            // txtAny
            // 
            txtAny.Location = new Point(206, 52);
            txtAny.Name = "txtAny";
            txtAny.Size = new Size(68, 23);
            txtAny.TabIndex = 3;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(280, 52);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(62, 23);
            txtISBN.TabIndex = 4;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(228, 45);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnAfegir
            // 
            btnAfegir.Location = new Point(446, 51);
            btnAfegir.Name = "btnAfegir";
            btnAfegir.Size = new Size(75, 23);
            btnAfegir.TabIndex = 6;
            btnAfegir.Text = "Afegir";
            btnAfegir.UseVisualStyleBackColor = true;
            btnAfegir.Click += btnAfegir_Click;
            // 
            // lstLlibres
            // 
            lstLlibres.FormattingEnabled = true;
            lstLlibres.ItemHeight = 15;
            lstLlibres.Location = new Point(8, 45);
            lstLlibres.Name = "lstLlibres";
            lstLlibres.Size = new Size(206, 139);
            lstLlibres.TabIndex = 7;
            lstLlibres.SelectedIndexChanged += lstLlibres_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 8;
            label1.Text = "Títol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 34);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 9;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 34);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 10;
            label3.Text = "Any";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 34);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 11;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 34);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 12;
            label5.Text = "Tipus";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(228, 74);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // bntEliminar
            // 
            bntEliminar.Location = new Point(228, 161);
            bntEliminar.Name = "bntEliminar";
            bntEliminar.Size = new Size(75, 23);
            bntEliminar.TabIndex = 15;
            bntEliminar.Text = "Eliminar";
            bntEliminar.UseVisualStyleBackColor = true;
            bntEliminar.Click += bntEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(228, 103);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(228, 132);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(75, 23);
            btnCarregar.TabIndex = 17;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAfegir);
            groupBox1.Controls.Add(cmbTipus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTitol);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAutor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(txtAny);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 100);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Afegir Llibres";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnMostrar);
            groupBox2.Controls.Add(bntEliminar);
            groupBox2.Controls.Add(btnCarregar);
            groupBox2.Controls.Add(lstLlibres);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(12, 127);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 206);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Llista Llibres";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 372);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Gestió de biblioteca";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbTipus;
        private TextBox txtTitol;
        private TextBox txtAutor;
        private TextBox txtAny;
        private TextBox txtISBN;
        private Button btnMostrar;
        private Button btnAfegir;
        private ListBox lstLlibres;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEditar;
        private Button bntEliminar;
        private Button btnGuardar;
        private Button btnCarregar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}
