namespace Exe2_Kelompok21_B
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.supermarketDataSet = new Exe2_Kelompok21_B.SupermarketDataSet();
            this.supermarketDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kasirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasirTableAdapter = new Exe2_Kelompok21_B.SupermarketDataSetTableAdapters.KasirTableAdapter();
            this.idKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supermarketDataSet
            // 
            this.supermarketDataSet.DataSetName = "SupermarketDataSet";
            this.supermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supermarketDataSetBindingSource
            // 
            this.supermarketDataSetBindingSource.DataSource = this.supermarketDataSet;
            this.supermarketDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKasirDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.namaKasirDataGridViewTextBoxColumn,
            this.idPembeliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasirBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(696, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // kasirBindingSource
            // 
            this.kasirBindingSource.DataMember = "Kasir";
            this.kasirBindingSource.DataSource = this.supermarketDataSetBindingSource;
            // 
            // kasirTableAdapter
            // 
            this.kasirTableAdapter.ClearBeforeFill = true;
            // 
            // idKasirDataGridViewTextBoxColumn
            // 
            this.idKasirDataGridViewTextBoxColumn.DataPropertyName = "Id_Kasir";
            this.idKasirDataGridViewTextBoxColumn.HeaderText = "Id_Kasir";
            this.idKasirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idKasirDataGridViewTextBoxColumn.Name = "idKasirDataGridViewTextBoxColumn";
            this.idKasirDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKasirDataGridViewTextBoxColumn.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaKasirDataGridViewTextBoxColumn
            // 
            this.namaKasirDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kasir";
            this.namaKasirDataGridViewTextBoxColumn.HeaderText = "Nama_Kasir";
            this.namaKasirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaKasirDataGridViewTextBoxColumn.Name = "namaKasirDataGridViewTextBoxColumn";
            this.namaKasirDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaKasirDataGridViewTextBoxColumn.Width = 150;
            // 
            // idPembeliDataGridViewTextBoxColumn
            // 
            this.idPembeliDataGridViewTextBoxColumn.DataPropertyName = "Id_Pembeli";
            this.idPembeliDataGridViewTextBoxColumn.HeaderText = "Id_Pembeli";
            this.idPembeliDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPembeliDataGridViewTextBoxColumn.Name = "idPembeliDataGridViewTextBoxColumn";
            this.idPembeliDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPembeliDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource supermarketDataSetBindingSource;
        private SupermarketDataSet supermarketDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kasirBindingSource;
        private SupermarketDataSetTableAdapters.KasirTableAdapter kasirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}