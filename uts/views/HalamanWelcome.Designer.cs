namespace uts.views
{
    partial class HalamanWelcome
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
            labelWelcome = new Label();
            buttonKontak = new Button();
            buttonRegister = new Button();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Fredoka", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(182, 194);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(467, 50);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome to Contact App";
            labelWelcome.Click += label1_Click;
            // 
            // buttonKontak
            // 
            buttonKontak.Location = new Point(606, 392);
            buttonKontak.Name = "buttonKontak";
            buttonKontak.Size = new Size(156, 34);
            buttonKontak.TabIndex = 1;
            buttonKontak.Text = "Kontak";
            buttonKontak.UseVisualStyleBackColor = true;
            buttonKontak.Click += buttonKontak_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(531, 21);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(112, 34);
            buttonRegister.TabIndex = 2;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveBorder;
            buttonLogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogin.Location = new Point(662, 21);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 34);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // HalamanWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(buttonRegister);
            Controls.Add(buttonKontak);
            Controls.Add(labelWelcome);
            Name = "HalamanWelcome";
            Text = "HalamanWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonKontak;
        private Button buttonRegister;
        private Button buttonLogin;
    }
}