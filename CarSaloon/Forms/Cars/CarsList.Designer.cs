namespace CarSaloon.Cars
{
    partial class CarsList
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
            backButton = new Button();
            countryComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            brandComboBox = new ComboBox();
            cleanCountryButton = new Button();
            cleanBrandButton = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 415);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 0;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(12, 27);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(100, 23);
            countryComboBox.TabIndex = 2;
            countryComboBox.Text = "Не выбрано";
            countryComboBox.Click += countryComboBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Страна:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 5;
            label2.Text = "Производитель:";
            // 
            // brandComboBox
            // 
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(147, 27);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(100, 23);
            brandComboBox.TabIndex = 4;
            brandComboBox.Text = "Не выбрано";
            brandComboBox.Click += brandComboBox_Click;
            // 
            // cleanCountryButton
            // 
            cleanCountryButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cleanCountryButton.Location = new Point(118, 27);
            cleanCountryButton.Name = "cleanCountryButton";
            cleanCountryButton.Size = new Size(23, 23);
            cleanCountryButton.TabIndex = 6;
            cleanCountryButton.Text = "X";
            cleanCountryButton.TextAlign = ContentAlignment.MiddleRight;
            cleanCountryButton.UseVisualStyleBackColor = true;
            cleanCountryButton.Click += cleanCountryButton_Click;
            // 
            // cleanBrandButton
            // 
            cleanBrandButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cleanBrandButton.Location = new Point(253, 27);
            cleanBrandButton.Name = "cleanBrandButton";
            cleanBrandButton.Size = new Size(23, 23);
            cleanBrandButton.TabIndex = 7;
            cleanBrandButton.Text = "X";
            cleanBrandButton.TextAlign = ContentAlignment.MiddleRight;
            cleanBrandButton.UseVisualStyleBackColor = true;
            cleanBrandButton.Click += cleanBrandButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 56);
            listView1.Name = "listView1";
            listView1.Size = new Size(273, 97);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CarsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(cleanBrandButton);
            Controls.Add(cleanCountryButton);
            Controls.Add(label2);
            Controls.Add(brandComboBox);
            Controls.Add(label1);
            Controls.Add(countryComboBox);
            Controls.Add(backButton);
            Name = "CarsList";
            Text = "CarsList";
            FormClosing += CarsList_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private ComboBox countryComboBox;
        private Label label1;
        private Label label2;
        private ComboBox brandComboBox;
        private Button cleanCountryButton;
        private Button cleanBrandButton;
        private ListView listView1;
    }
}