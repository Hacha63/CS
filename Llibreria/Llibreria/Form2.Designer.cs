namespace Llibreria
{
    partial class FrmDetallsProducte
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPreu = new System.Windows.Forms.Label();
            this.btnTancar = new System.Windows.Forms.Button();
            this.lblTipus = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(67, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblPreu
            // 
            this.lblPreu.AutoSize = true;
            this.lblPreu.Location = new System.Drawing.Point(67, 65);
            this.lblPreu.Name = "lblPreu";
            this.lblPreu.Size = new System.Drawing.Size(29, 13);
            this.lblPreu.TabIndex = 2;
            this.lblPreu.Text = "Preu";
            // 
            // btnTancar
            // 
            this.btnTancar.Location = new System.Drawing.Point(183, 148);
            this.btnTancar.Name = "btnTancar";
            this.btnTancar.Size = new System.Drawing.Size(75, 23);
            this.btnTancar.TabIndex = 3;
            this.btnTancar.Text = "Tancar";
            this.btnTancar.UseVisualStyleBackColor = true;
            this.btnTancar.Click += new System.EventHandler(this.btnTancar_Click);
            // 
            // lblTipus
            // 
            this.lblTipus.AutoSize = true;
            this.lblTipus.Location = new System.Drawing.Point(189, 26);
            this.lblTipus.Name = "lblTipus";
            this.lblTipus.Size = new System.Drawing.Size(33, 13);
            this.lblTipus.TabIndex = 4;
            this.lblTipus.Text = "Tipus";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(189, 65);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(31, 13);
            this.lblExtra.TabIndex = 6;
            this.lblExtra.Text = "Extra";
            // 
            // FrmDetallsProducte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 244);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblTipus);
            this.Controls.Add(this.btnTancar);
            this.Controls.Add(this.lblPreu);
            this.Controls.Add(this.lblNom);
            this.Name = "FrmDetallsProducte";
            this.Text = "FrmDetallsProducte";
            this.Load += new System.EventHandler(this.FrmDetallsProducte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPreu;
        private System.Windows.Forms.Button btnTancar;
        private System.Windows.Forms.Label lblTipus;
        private System.Windows.Forms.Label lblExtra;
    }
}