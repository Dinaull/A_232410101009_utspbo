namespace uts.views
{
    partial class HalamanLoginAdmin
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
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonMasuk = new Button();
            buttonbatal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 48);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(153, 141);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(153, 185);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(87, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(298, 141);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(412, 31);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(298, 185);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(412, 31);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonMasuk
            // 
            buttonMasuk.Location = new Point(507, 386);
            buttonMasuk.Name = "buttonMasuk";
            buttonMasuk.Size = new Size(112, 34);
            buttonMasuk.TabIndex = 5;
            buttonMasuk.Text = "Masuk";
            buttonMasuk.UseVisualStyleBackColor = true;
            buttonMasuk.Click += buttonMasuk_Click;
            // 
            // buttonbatal
            // 
            buttonbatal.Location = new Point(644, 386);
            buttonbatal.Name = "buttonbatal";
            buttonbatal.Size = new Size(112, 34);
            buttonbatal.TabIndex = 6;
            buttonbatal.Text = "Batal";
            buttonbatal.UseVisualStyleBackColor = true;
            buttonbatal.Click += buttonbatal_Click;
            // 
            // HalamanLoginAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonbatal);
            Controls.Add(buttonMasuk);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(label1);
            Name = "HalamanLoginAdmin";
            Text = "HalamanLoginAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonMasuk;
        private Button buttonbatal;
    }
}