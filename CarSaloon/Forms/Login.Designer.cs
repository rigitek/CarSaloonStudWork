namespace CarSaloon.Forms
{
    partial class Login
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
            loginTextBox = new TextBox();
            loginButton = new Button();
            label2 = new Label();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 0;
            label1.Text = "Введите логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginTextBox.Location = new Point(12, 42);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(200, 25);
            loginTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.Location = new Point(12, 121);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 25);
            loginButton.TabIndex = 2;
            loginButton.Text = "Войти в систему";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 3;
            label2.Text = "Введите пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTextBox.Location = new Point(12, 90);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 25);
            passwordTextBox.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 157);
            Controls.Add(passwordTextBox);
            Controls.Add(label2);
            Controls.Add(loginButton);
            Controls.Add(loginTextBox);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginTextBox;
        private Button loginButton;
        private Label label2;
        private TextBox passwordTextBox;
    }
}