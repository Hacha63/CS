namespace Conversor
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtdolar = new TextBox();
            txteuro = new TextBox();
            txtyen = new TextBox();
            txtfranc = new TextBox();
            txtlliure = new TextBox();
            btnconvertir = new Button();
            btnsortir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 46);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Dolar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 143);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "Yen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 114);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Euro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 172);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Franco";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 201);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Libra";
            // 
            // txtdolar
            // 
            txtdolar.Location = new Point(90, 43);
            txtdolar.Name = "txtdolar";
            txtdolar.Size = new Size(100, 23);
            txtdolar.TabIndex = 5;
            // 
            // txteuro
            // 
            txteuro.Location = new Point(90, 111);
            txteuro.Name = "txteuro";
            txteuro.Size = new Size(100, 23);
            txteuro.TabIndex = 6;
            // 
            // txtyen
            // 
            txtyen.Location = new Point(90, 140);
            txtyen.Name = "txtyen";
            txtyen.Size = new Size(100, 23);
            txtyen.TabIndex = 7;
            // 
            // txtfranc
            // 
            txtfranc.Location = new Point(90, 169);
            txtfranc.Name = "txtfranc";
            txtfranc.Size = new Size(100, 23);
            txtfranc.TabIndex = 8;
            // 
            // txtlliure
            // 
            txtlliure.Location = new Point(90, 198);
            txtlliure.Name = "txtlliure";
            txtlliure.Size = new Size(100, 23);
            txtlliure.TabIndex = 9;
            // 
            // btnconvertir
            // 
            btnconvertir.FlatStyle = FlatStyle.Flat;
            btnconvertir.Location = new Point(391, 43);
            btnconvertir.Name = "btnconvertir";
            btnconvertir.RightToLeft = RightToLeft.No;
            btnconvertir.Size = new Size(75, 23);
            btnconvertir.TabIndex = 10;
            btnconvertir.Text = "Convertir";
            btnconvertir.UseVisualStyleBackColor = true;
            btnconvertir.Click += btnconvertir_Click;
            // 
            // btnsortir
            // 
            btnsortir.Location = new Point(396, 193);
            btnsortir.Name = "btnsortir";
            btnsortir.Size = new Size(75, 23);
            btnsortir.TabIndex = 11;
            btnsortir.Text = "Sortir";
            btnsortir.UseVisualStyleBackColor = true;
            btnsortir.Click += btnsortir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 257);
            Controls.Add(btnsortir);
            Controls.Add(btnconvertir);
            Controls.Add(txtlliure);
            Controls.Add(txtfranc);
            Controls.Add(txtyen);
            Controls.Add(txteuro);
            Controls.Add(txtdolar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtdolar;
        private TextBox txteuro;
        private TextBox txtyen;
        private TextBox txtfranc;
        private TextBox txtlliure;
        private Button btnconvertir;
        private Button btnsortir;
    }
}
