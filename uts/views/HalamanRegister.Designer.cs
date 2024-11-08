namespace uts.views
{
    partial class HalamanRegister
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
            labelRegister = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNama = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNomorHp = new TextBox();
            buttonRegister = new Button();
            buttonbatal = new Button();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegister.Location = new Point(342, 20);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(157, 48);
            labelRegister.TabIndex = 0;
            labelRegister.Text = "Register";
            labelRegister.Click += labelRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 106);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 167);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 221);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 3;
            label3.Text = "Nomor HP";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(176, 100);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(569, 31);
            textBoxNama.TabIndex = 4;
            textBoxNama.TextChanged += textBoxNama_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(176, 167);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(569, 31);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxNomorHp
            // 
            textBoxNomorHp.Location = new Point(176, 218);
            textBoxNomorHp.Name = "textBoxNomorHp";
            textBoxNomorHp.Size = new Size(569, 31);
            textBoxNomorHp.TabIndex = 6;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(505, 390);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(112, 34);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonbatal
            // 
            buttonbatal.Location = new Point(650, 390);
            buttonbatal.Name = "buttonbatal";
            buttonbatal.Size = new Size(112, 34);
            buttonbatal.TabIndex = 8;
            buttonbatal.Text = "Batal";
            buttonbatal.UseVisualStyleBackColor = true;
            buttonbatal.Click += buttonbatal_Click;
            // 
            // HalamanRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonbatal);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxNomorHp);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelRegister);
            Name = "HalamanRegister";
            Text = "HalamanRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNama;
        private TextBox textBoxEmail;
        private TextBox textBoxNomorHp;
        private Button buttonRegister;
        private Button buttonbatal;
    }
}