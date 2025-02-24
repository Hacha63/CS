namespace ExamenC_
{
    partial class FrmDetallsEstudiant
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
            this.lblMerit = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtEdat = new System.Windows.Forms.TextBox();
            this.lblEdat = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.txtMerit = new System.Windows.Forms.TextBox();
            this.btnTancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMerit
            // 
            this.lblMerit.AutoSize = true;
            this.lblMerit.Location = new System.Drawing.Point(224, 29);
            this.lblMerit.Name = "lblMerit";
            this.lblMerit.Size = new System.Drawing.Size(63, 13);
            this.lblMerit.TabIndex = 20;
            this.lblMerit.Text = "Mèrit escial:";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(67, 172);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(36, 13);
            this.lblClasse.TabIndex = 19;
            this.lblClasse.Text = "Clase:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(71, 135);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(121, 20);
            this.txtNota.TabIndex = 18;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(66, 119);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 17;
            this.lblNota.Text = "Nota:";
            // 
            // txtEdat
            // 
            this.txtEdat.Location = new System.Drawing.Point(71, 89);
            this.txtEdat.Name = "txtEdat";
            this.txtEdat.Size = new System.Drawing.Size(121, 20);
            this.txtEdat.TabIndex = 16;
            // 
            // lblEdat
            // 
            this.lblEdat.AutoSize = true;
            this.lblEdat.Location = new System.Drawing.Point(68, 73);
            this.lblEdat.Name = "lblEdat";
            this.lblEdat.Size = new System.Drawing.Size(32, 13);
            this.lblEdat.TabIndex = 15;
            this.lblEdat.Text = "Edat:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(226, 86);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Eliminar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(71, 45);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 12;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(68, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nom:";
            // 
            // txtClasse
            // 
            this.txtClasse.Location = new System.Drawing.Point(71, 188);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(121, 20);
            this.txtClasse.TabIndex = 22;
            // 
            // txtMerit
            // 
            this.txtMerit.Location = new System.Drawing.Point(226, 45);
            this.txtMerit.Name = "txtMerit";
            this.txtMerit.Size = new System.Drawing.Size(155, 20);
            this.txtMerit.TabIndex = 23;
            // 
            // btnTancar
            // 
            this.btnTancar.Location = new System.Drawing.Point(226, 132);
            this.btnTancar.Name = "btnTancar";
            this.btnTancar.Size = new System.Drawing.Size(111, 23);
            this.btnTancar.TabIndex = 24;
            this.btnTancar.Text = "Tancar";
            this.btnTancar.UseVisualStyleBackColor = true;
            this.btnTancar.Click += new System.EventHandler(this.btnTancar_Click);
            // 
            // FrmDetallsEstudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 276);
            this.Controls.Add(this.btnTancar);
            this.Controls.Add(this.txtMerit);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.lblMerit);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtEdat);
            this.Controls.Add(this.lblEdat);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "FrmDetallsEstudiant";
            this.Text = "FrmDetallsEstudiant";
            this.Load += new System.EventHandler(this.FrmDetallsEstudiant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMerit;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtEdat;
        private System.Windows.Forms.Label lblEdat;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.TextBox txtMerit;
        private System.Windows.Forms.Button btnTancar;
    }
}