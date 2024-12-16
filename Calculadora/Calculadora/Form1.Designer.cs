namespace Calculadora
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
            label1 = new Label();
            btnmultiplicar = new Button();
            btnsumar = new Button();
            btnrestar = new Button();
            btndividir = new Button();
            btnpotencia = new Button();
            btnraiz = new Button();
            btnlimpliar = new Button();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            txtresultado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(88, 84);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "Calculadora";
            label1.Click += label1_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.BackColor = Color.White;
            btnmultiplicar.Font = new Font("Segoe UI", 14F);
            btnmultiplicar.Location = new Point(266, 148);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(75, 35);
            btnmultiplicar.TabIndex = 12;
            btnmultiplicar.Text = "*";
            btnmultiplicar.UseVisualStyleBackColor = false;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btnsumar
            // 
            btnsumar.BackColor = Color.White;
            btnsumar.BackgroundImageLayout = ImageLayout.None;
            btnsumar.Font = new Font("Segoe UI", 14F);
            btnsumar.Location = new Point(266, 90);
            btnsumar.Name = "btnsumar";
            btnsumar.Size = new Size(75, 35);
            btnsumar.TabIndex = 13;
            btnsumar.Text = "+";
            btnsumar.UseVisualStyleBackColor = false;
            btnsumar.Click += btnsumar_Click;
            // 
            // btnrestar
            // 
            btnrestar.BackColor = Color.White;
            btnrestar.Font = new Font("Segoe UI", 14F);
            btnrestar.Location = new Point(368, 90);
            btnrestar.Name = "btnrestar";
            btnrestar.RightToLeft = RightToLeft.No;
            btnrestar.Size = new Size(75, 35);
            btnrestar.TabIndex = 14;
            btnrestar.Text = "-";
            btnrestar.UseVisualStyleBackColor = false;
            btnrestar.Click += btnrestar_Click;
            // 
            // btndividir
            // 
            btndividir.BackColor = Color.White;
            btndividir.Location = new Point(368, 148);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(75, 35);
            btndividir.TabIndex = 15;
            btndividir.Text = "/";
            btndividir.UseVisualStyleBackColor = false;
            btndividir.Click += btndividir_Click;
            // 
            // btnpotencia
            // 
            btnpotencia.BackColor = Color.White;
            btnpotencia.Font = new Font("Microsoft Sans Serif", 11F);
            btnpotencia.Location = new Point(368, 206);
            btnpotencia.Name = "btnpotencia";
            btnpotencia.Size = new Size(75, 35);
            btnpotencia.TabIndex = 17;
            btnpotencia.Text = "Potencia";
            btnpotencia.UseVisualStyleBackColor = false;
            btnpotencia.Click += btnpotencia_Click;
            // 
            // btnraiz
            // 
            btnraiz.BackColor = Color.White;
            btnraiz.Font = new Font("Segoe UI", 12F);
            btnraiz.Location = new Point(266, 206);
            btnraiz.Name = "btnraiz";
            btnraiz.Size = new Size(75, 35);
            btnraiz.TabIndex = 16;
            btnraiz.Text = "Raiz";
            btnraiz.UseVisualStyleBackColor = false;
            btnraiz.Click += btnraiz_Click;
            // 
            // btnlimpliar
            // 
            btnlimpliar.BackColor = Color.White;
            btnlimpliar.Font = new Font("Segoe UI", 12F);
            btnlimpliar.Location = new Point(309, 259);
            btnlimpliar.Name = "btnlimpliar";
            btnlimpliar.Size = new Size(75, 35);
            btnlimpliar.TabIndex = 18;
            btnlimpliar.Text = "Limpiar";
            btnlimpliar.UseVisualStyleBackColor = false;
            btnlimpliar.Click += btnlimpliar_Click;
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(88, 102);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(100, 23);
            txtnum1.TabIndex = 19;
            txtnum1.TextChanged += txtnum1_TextChanged;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(88, 160);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(100, 23);
            txtnum2.TabIndex = 20;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(88, 218);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(100, 23);
            txtresultado.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(88, 200);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 22;
            label2.Text = "Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(88, 20);
            label3.Name = "label3";
            label3.Size = new Size(309, 31);
            label3.TabIndex = 23;
            label3.Text = "Calculadora Aritmetica";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(494, 384);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtresultado);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(btnlimpliar);
            Controls.Add(btnpotencia);
            Controls.Add(btnraiz);
            Controls.Add(btndividir);
            Controls.Add(btnrestar);
            Controls.Add(btnsumar);
            Controls.Add(btnmultiplicar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnmultiplicar;
        private Button btnsumar;
        private Button btnrestar;
        private Button btndividir;
        private Button btnpotencia;
        private Button btnraiz;
        private Button btnlimpliar;
        private TextBox txtnum1;
        private TextBox txtnum2;
        private TextBox txtresultado;
        private Label label2;
        private Label label3;
    }
}
