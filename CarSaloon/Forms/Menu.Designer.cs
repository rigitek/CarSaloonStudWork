namespace CarSaloon
{
    partial class Menu
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
            carsButton = new Button();
            clientsButton = new Button();
            salesButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // carsButton
            // 
            carsButton.Location = new Point(58, 58);
            carsButton.Name = "carsButton";
            carsButton.Size = new Size(200, 40);
            carsButton.TabIndex = 0;
            carsButton.Text = "Автомобили";
            carsButton.UseVisualStyleBackColor = true;
            carsButton.Click += carsButton_Click;
            // 
            // clientsButton
            // 
            clientsButton.Location = new Point(58, 104);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(200, 40);
            clientsButton.TabIndex = 1;
            clientsButton.Text = "Клиенты";
            clientsButton.UseVisualStyleBackColor = true;
            clientsButton.Click += clientsButton_Click;
            // 
            // salesButton
            // 
            salesButton.Location = new Point(58, 150);
            salesButton.Name = "salesButton";
            salesButton.Size = new Size(200, 40);
            salesButton.TabIndex = 2;
            salesButton.Text = "Продажи";
            salesButton.UseVisualStyleBackColor = true;
            salesButton.Click += salesButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(58, 196);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 40);
            exitButton.TabIndex = 3;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 287);
            Controls.Add(exitButton);
            Controls.Add(salesButton);
            Controls.Add(clientsButton);
            Controls.Add(carsButton);
            Name = "Menu";
            Text = "Автосалон \"АвтоПрофи\"";
            FormClosed += Menu_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button carsButton;
        private Button clientsButton;
        private Button salesButton;
        private Button exitButton;
    }
}
