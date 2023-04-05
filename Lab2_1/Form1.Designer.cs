namespace Lab2_1
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
            btnLogin = new Button();
            txtBoxUser = new TextBox();
            txtBoxPass = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(307, 232);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login\r\n";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(211, 135);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(317, 31);
            txtBoxUser.TabIndex = 1;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Location = new Point(211, 185);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.Size = new Size(317, 31);
            txtBoxPass.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxPass);
            Controls.Add(txtBoxUser);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtBoxUser;
        private TextBox txtBoxPass;
    }
}