﻿namespace uts.views
{
    partial class FormKontakBaru
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonTambahKontak = new Button();
            buttonBatal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(371, 48);
            label1.TabIndex = 0;
            label1.Text = "Tambah Kontak Baru";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 104);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 167);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 234);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 3;
            label4.Text = "Nomor HP";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(533, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(533, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(533, 31);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // buttonTambahKontak
            // 
            buttonTambahKontak.Location = new Point(418, 367);
            buttonTambahKontak.Name = "buttonTambahKontak";
            buttonTambahKontak.Size = new Size(186, 34);
            buttonTambahKontak.TabIndex = 7;
            buttonTambahKontak.Text = "Tambah Kontak";
            buttonTambahKontak.UseVisualStyleBackColor = true;
            buttonTambahKontak.Click += buttonTambahKontak_Click;
            // 
            // buttonBatal
            // 
            buttonBatal.Location = new Point(639, 367);
            buttonBatal.Name = "buttonBatal";
            buttonBatal.Size = new Size(113, 34);
            buttonBatal.TabIndex = 8;
            buttonBatal.Text = "Batal";
            buttonBatal.UseVisualStyleBackColor = true;
            buttonBatal.Click += button1_Click;
            // 
            // FormKontakBaru
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBatal);
            Controls.Add(buttonTambahKontak);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormKontakBaru";
            Text = "FormKontakBaru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonTambahKontak;
        private Button buttonBatal;
    }
}