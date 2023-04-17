namespace FurnitureCompany
{
    partial class LoginForm
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
            buttonLogin = new Button();
            labelLogin = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxLogin = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(12, 178);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(281, 35);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Увійти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelLogin
            // 
            labelLogin.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(12, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(281, 50);
            labelLogin.TabIndex = 6;
            labelLogin.Text = "Вхід";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(88, 72);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(205, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 75);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(88, 138);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(205, 27);
            textBoxPassword.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 8;
            label1.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(88, 105);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(205, 27);
            textBoxLogin.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Login:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 225);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Controls.Add(labelLogin);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Name = "LoginForm";
            Text = "Логін";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelLogin;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxPassword;
        private Label label1;
        private TextBox textBoxLogin;
        private Label label2;
    }
}