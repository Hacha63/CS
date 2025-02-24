namespace ExamenC_
{
    partial class FrmExamen
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.btnAfegir = new System.Windows.Forms.Button();
            this.lblEdat = new System.Windows.Forms.Label();
            this.txtEdat = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblTipus = new System.Windows.Forms.Label();
            this.cmbTipus = new System.Windows.Forms.ComboBox();
            this.lstEstudiants = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtMèrit = new System.Windows.Forms.TextBox();
            this.lblMèrit = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(49, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(52, 41);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 1;
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(52, 184);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(121, 21);
            this.cmbClasse.TabIndex = 2;
            this.cmbClasse.SelectedIndexChanged += new System.EventHandler(this.cmbClasse_SelectedIndexChanged);
            // 
            // btnAfegir
            // 
            this.btnAfegir.Location = new System.Drawing.Point(62, 298);
            this.btnAfegir.Name = "btnAfegir";
            this.btnAfegir.Size = new System.Drawing.Size(111, 23);
            this.btnAfegir.TabIndex = 3;
            this.btnAfegir.Text = "Afegir esudiant";
            this.btnAfegir.UseVisualStyleBackColor = true;
            this.btnAfegir.Click += new System.EventHandler(this.btnAfegir_Click);
            // 
            // lblEdat
            // 
            this.lblEdat.AutoSize = true;
            this.lblEdat.Location = new System.Drawing.Point(49, 69);
            this.lblEdat.Name = "lblEdat";
            this.lblEdat.Size = new System.Drawing.Size(32, 13);
            this.lblEdat.TabIndex = 4;
            this.lblEdat.Text = "Edat:";
            // 
            // txtEdat
            // 
            this.txtEdat.Location = new System.Drawing.Point(52, 85);
            this.txtEdat.Name = "txtEdat";
            this.txtEdat.Size = new System.Drawing.Size(121, 20);
            this.txtEdat.TabIndex = 5;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(47, 115);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 6;
            this.lblNota.Text = "Nota:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(52, 131);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(121, 20);
            this.txtNota.TabIndex = 7;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(48, 168);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(36, 13);
            this.lblClasse.TabIndex = 8;
            this.lblClasse.Text = "Clase:";
            // 
            // lblTipus
            // 
            this.lblTipus.AutoSize = true;
            this.lblTipus.Location = new System.Drawing.Point(49, 216);
            this.lblTipus.Name = "lblTipus";
            this.lblTipus.Size = new System.Drawing.Size(36, 13);
            this.lblTipus.TabIndex = 9;
            this.lblTipus.Text = "Tipus:";
            // 
            // cmbTipus
            // 
            this.cmbTipus.FormattingEnabled = true;
            this.cmbTipus.Location = new System.Drawing.Point(52, 232);
            this.cmbTipus.Name = "cmbTipus";
            this.cmbTipus.Size = new System.Drawing.Size(121, 21);
            this.cmbTipus.TabIndex = 10;
            // 
            // lstEstudiants
            // 
            this.lstEstudiants.FormattingEnabled = true;
            this.lstEstudiants.Location = new System.Drawing.Point(193, 41);
            this.lstEstudiants.Name = "lstEstudiants";
            this.lstEstudiants.Size = new System.Drawing.Size(183, 251);
            this.lstEstudiants.TabIndex = 11;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(193, 298);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(111, 23);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar detalls";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtMèrit
            // 
            this.txtMèrit.Location = new System.Drawing.Point(52, 272);
            this.txtMèrit.Name = "txtMèrit";
            this.txtMèrit.Size = new System.Drawing.Size(121, 20);
            this.txtMèrit.TabIndex = 13;
            // 
            // lblMèrit
            // 
            this.lblMèrit.AutoSize = true;
            this.lblMèrit.Location = new System.Drawing.Point(52, 256);
            this.lblMèrit.Name = "lblMèrit";
            this.lblMèrit.Size = new System.Drawing.Size(30, 13);
            this.lblMèrit.TabIndex = 14;
            this.lblMèrit.Text = "Mèrit";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(310, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(66, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 349);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblMèrit);
            this.Controls.Add(this.txtMèrit);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lstEstudiants);
            this.Controls.Add(this.cmbTipus);
            this.Controls.Add(this.lblTipus);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtEdat);
            this.Controls.Add(this.lblEdat);
            this.Controls.Add(this.btnAfegir);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "FrmExamen";
            this.Text = "FrmExamen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.Button btnAfegir;
        private System.Windows.Forms.Label lblEdat;
        private System.Windows.Forms.TextBox txtEdat;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblTipus;
        private System.Windows.Forms.ComboBox cmbTipus;
        private System.Windows.Forms.ListBox lstEstudiants;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtMèrit;
        private System.Windows.Forms.Label lblMèrit;
        private System.Windows.Forms.Button btnEliminar;
    }
}

