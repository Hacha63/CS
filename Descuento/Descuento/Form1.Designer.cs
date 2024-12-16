namespace Descuento
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
            txtcantidad = new TextBox();
            btncalcular = new Button();
            label3 = new Label();
            label4 = new Label();
            txtprecio = new TextBox();
            txtdescuento = new TextBox();
            txttotal = new TextBox();
            btnlimpiar = new Button();
            groupBox1 = new GroupBox();
            radio20 = new RadioButton();
            radio15 = new RadioButton();
            radio10 = new RadioButton();
            radio5 = new RadioButton();
            radio0 = new RadioButton();
            btnsalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 65);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 97);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(114, 62);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 2;
            // 
            // btncalcular
            // 
            btncalcular.FlatAppearance.BorderColor = Color.Blue;
            btncalcular.FlatAppearance.BorderSize = 3;
            btncalcular.Location = new Point(125, 135);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 177);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Descuento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 210);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Total";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(114, 94);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 7;
            // 
            // txtdescuento
            // 
            txtdescuento.BackColor = SystemColors.Window;
            txtdescuento.Location = new Point(114, 174);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.Size = new Size(100, 23);
            txtdescuento.TabIndex = 8;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(114, 207);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(100, 23);
            txttotal.TabIndex = 9;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(307, 248);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 15;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(radio20);
            groupBox1.Controls.Add(radio15);
            groupBox1.Controls.Add(radio10);
            groupBox1.Controls.Add(radio5);
            groupBox1.Controls.Add(radio0);
            groupBox1.Location = new Point(307, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(191, 168);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descuento";
            // 
            // radio20
            // 
            radio20.AutoSize = true;
            radio20.Location = new Point(15, 128);
            radio20.Name = "radio20";
            radio20.Size = new Size(47, 19);
            radio20.TabIndex = 19;
            radio20.TabStop = true;
            radio20.Text = "20%";
            radio20.UseVisualStyleBackColor = true;
            // 
            // radio15
            // 
            radio15.AutoSize = true;
            radio15.Location = new Point(15, 103);
            radio15.Name = "radio15";
            radio15.Size = new Size(47, 19);
            radio15.TabIndex = 18;
            radio15.TabStop = true;
            radio15.Text = "15%";
            radio15.UseVisualStyleBackColor = true;
            // 
            // radio10
            // 
            radio10.AutoSize = true;
            radio10.Location = new Point(15, 78);
            radio10.Name = "radio10";
            radio10.Size = new Size(47, 19);
            radio10.TabIndex = 17;
            radio10.TabStop = true;
            radio10.Text = "10%";
            radio10.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            radio5.AutoSize = true;
            radio5.Location = new Point(15, 53);
            radio5.Name = "radio5";
            radio5.Size = new Size(41, 19);
            radio5.TabIndex = 16;
            radio5.TabStop = true;
            radio5.Text = "5%";
            radio5.UseVisualStyleBackColor = true;
            // 
            // radio0
            // 
            radio0.AutoSize = true;
            radio0.Location = new Point(15, 28);
            radio0.Name = "radio0";
            radio0.Size = new Size(41, 19);
            radio0.TabIndex = 15;
            radio0.TabStop = true;
            radio0.Text = "0%";
            radio0.UseVisualStyleBackColor = true;
            radio0.CheckedChanged += radio0_CheckedChanged;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(423, 248);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 17;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 308);
            Controls.Add(btnsalir);
            Controls.Add(groupBox1);
            Controls.Add(btnlimpiar);
            Controls.Add(txttotal);
            Controls.Add(txtdescuento);
            Controls.Add(txtprecio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btncalcular);
            Controls.Add(txtcantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Aplicación para calcular el valor a pagar por la compra de un producto.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcantidad;
        private Button btncalcular;
        private Label label3;
        private Label label4;
        private TextBox txtprecio;
        private TextBox txtdescuento;
        private TextBox txttotal;
        private Button btnlimpiar;
        private GroupBox groupBox1;
        private RadioButton radio20;
        private RadioButton radio15;
        private RadioButton radio10;
        private RadioButton radio5;
        private RadioButton radio0;
        private Button btnsalir;
    }
}
