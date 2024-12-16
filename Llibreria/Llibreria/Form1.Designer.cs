namespace Llibreria
{
    partial class FrmProductes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPreu = new System.Windows.Forms.Label();
            this.lstProductes = new System.Windows.Forms.ListBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPreu = new System.Windows.Forms.TextBox();
            this.btnAfegir = new System.Windows.Forms.Button();
            this.btnDetalls = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lbExtra = new System.Windows.Forms.Label();
            this.cmbTipus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(75, 44);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(29, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom";
            // 
            // lbPreu
            // 
            this.lbPreu.AutoSize = true;
            this.lbPreu.Location = new System.Drawing.Point(75, 88);
            this.lbPreu.Name = "lbPreu";
            this.lbPreu.Size = new System.Drawing.Size(29, 13);
            this.lbPreu.TabIndex = 1;
            this.lbPreu.Text = "Preu";
            // 
            // lstProductes
            // 
            this.lstProductes.FormattingEnabled = true;
            this.lstProductes.Location = new System.Drawing.Point(256, 44);
            this.lstProductes.Name = "lstProductes";
            this.lstProductes.Size = new System.Drawing.Size(120, 95);
            this.lstProductes.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(129, 44);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtPreu
            // 
            this.txtPreu.Location = new System.Drawing.Point(129, 88);
            this.txtPreu.Name = "txtPreu";
            this.txtPreu.Size = new System.Drawing.Size(100, 20);
            this.txtPreu.TabIndex = 4;
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(116, 217);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(108, 23);
            this.btnAfegir.TabIndex = 5;
            this.btnAfegir.Text = "Afegir Producte";
            this.btnAfegir.UseVisualStyleBackColor = true;
            this.btnAfegir.Click += new System.EventHandler(this.btnAfegir_Click);
            // 
            // btnDetalls
            // 
            this.btnDetalls.Location = new System.Drawing.Point(269, 163);
            this.btnDetalls.Name = "btnDetalls";
            this.btnDetalls.Size = new System.Drawing.Size(95, 23);
            this.btnDetalls.TabIndex = 6;
            this.btnDetalls.Text = "Veure Detalls";
            this.btnDetalls.UseVisualStyleBackColor = true;
            this.btnDetalls.Click += new System.EventHandler(this.btnDetalls_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(129, 130);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(100, 20);
            this.txtExtra.TabIndex = 7;
            // 
            // lbExtra
            // 
            this.lbExtra.AutoSize = true;
            this.lbExtra.Location = new System.Drawing.Point(63, 137);
            this.lbExtra.Name = "lbExtra";
            this.lbExtra.Size = new System.Drawing.Size(60, 13);
            this.lbExtra.TabIndex = 8;
            this.lbExtra.Text = "Camp extra";
            // 
            // cmbTipus
            // 
            this.cmbTipus.FormattingEnabled = true;
            this.cmbTipus.Location = new System.Drawing.Point(116, 179);
            this.cmbTipus.Name = "cmbTipus";
            this.cmbTipus.Size = new System.Drawing.Size(121, 21);
            this.cmbTipus.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipus";
            // 
            // FrmProductes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipus);
            this.Controls.Add(this.lbExtra);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.btnDetalls);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.txtPreu);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lstProductes);
            this.Controls.Add(this.lbPreu);
            this.Controls.Add(this.lbNom);
            this.Name = "FrmProductes";
            this.Text = "FrmProductes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPreu;
        private System.Windows.Forms.ListBox lstProductes;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPreu;
        private System.Windows.Forms.Button btnAfegir;
        private System.Windows.Forms.Button btnDetalls;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lbExtra;
        private System.Windows.Forms.ComboBox cmbTipus;
        private System.Windows.Forms.Label label1;
    }
}

