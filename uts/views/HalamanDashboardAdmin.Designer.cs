namespace uts.views
{
    partial class HalamanDashboardAdmin
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
            dataGridView1 = new DataGridView();
            buttonTambahKontak = new Button();
            labelDaftarKontak = new Label();
            buttonBack = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 328);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonTambahKontak
            // 
            buttonTambahKontak.Location = new Point(511, 389);
            buttonTambahKontak.Name = "buttonTambahKontak";
            buttonTambahKontak.Size = new Size(159, 34);
            buttonTambahKontak.TabIndex = 1;
            buttonTambahKontak.Text = "Tambah Kontak";
            buttonTambahKontak.UseVisualStyleBackColor = true;
            buttonTambahKontak.Click += buttonTambahKontak_Click;
            // 
            // labelDaftarKontak
            // 
            labelDaftarKontak.AutoSize = true;
            labelDaftarKontak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDaftarKontak.Location = new Point(272, 4);
            labelDaftarKontak.Name = "labelDaftarKontak";
            labelDaftarKontak.Size = new Size(258, 48);
            labelDaftarKontak.TabIndex = 2;
            labelDaftarKontak.Text = "Daftar Kontak";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(676, 389);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(112, 34);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Email";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nomor HP";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // HalamanDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(labelDaftarKontak);
            Controls.Add(buttonTambahKontak);
            Controls.Add(dataGridView1);
            Name = "HalamanDashboardAdmin";
            Text = "HalamanDashboardAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonTambahKontak;
        private Label labelDaftarKontak;
        private Button buttonBack;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}