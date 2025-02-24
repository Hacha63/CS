namespace DataGridViewExample
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            btnAddRow = new Button();
            btnRemoveRow = new Button();
            btnClearData = new Button();
            btnSortir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridView1.Size = new Size(509, 97);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAddRow
            // 
            btnAddRow.Location = new Point(12, 115);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(111, 23);
            btnAddRow.TabIndex = 1;
            btnAddRow.Text = "Afegir Fila";
            btnAddRow.UseVisualStyleBackColor = true;
            btnAddRow.Click += btnAddRow_Click;
            // 
            // btnRemoveRow
            // 
            btnRemoveRow.Location = new Point(129, 114);
            btnRemoveRow.Name = "btnRemoveRow";
            btnRemoveRow.Size = new Size(108, 23);
            btnRemoveRow.TabIndex = 2;
            btnRemoveRow.Text = "Eliminar Fila";
            btnRemoveRow.UseVisualStyleBackColor = true;
            btnRemoveRow.Click += btnRemoveRow_Click;
            // 
            // btnClearData
            // 
            btnClearData.Location = new Point(243, 114);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(164, 23);
            btnClearData.TabIndex = 3;
            btnClearData.Text = "Eliminar Totes les Dades";
            btnClearData.UseVisualStyleBackColor = true;
            btnClearData.Click += btnClearData_Click;
            // 
            // btnSortir
            // 
            btnSortir.Location = new Point(413, 115);
            btnSortir.Name = "btnSortir";
            btnSortir.Size = new Size(108, 23);
            btnSortir.TabIndex = 4;
            btnSortir.Text = "Sortir";
            btnSortir.UseVisualStyleBackColor = true;
            btnSortir.Click += btnSortir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 151);
            Controls.Add(btnSortir);
            Controls.Add(btnClearData);
            Controls.Add(btnRemoveRow);
            Controls.Add(btnAddRow);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddRow;
        private Button btnRemoveRow;
        private Button btnClearData;
        private Button btnSortir;
    }
}
