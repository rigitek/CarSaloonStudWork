namespace CarSaloon.Forms.HistorySales
{
    partial class HistorySalesList
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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            brandComboBox = new ComboBox();
            label6 = new Label();
            countryComboBox = new ComboBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(498, 222);
            backButton.Name = "backButton";
            backButton.Size = new Size(269, 30);
            backButton.TabIndex = 1;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(481, 213);
            dataGridView1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(557, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(600, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 4;
            label1.Text = "Фильтрация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 45);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Дата с:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 74);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Дата по:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(557, 68);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(210, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 8;
            label4.Text = "История продаж";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 129);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 12;
            label5.Text = "Производитель:";
            // 
            // brandComboBox
            // 
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(600, 126);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(167, 23);
            brandComboBox.TabIndex = 11;
            brandComboBox.Text = "Не выбрано";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 100);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 10;
            label6.Text = "Страна:";
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(554, 97);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(213, 23);
            countryComboBox.TabIndex = 9;
            countryComboBox.Text = "Не выбрано";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(499, 158);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 14;
            label7.Text = "Клиент:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(554, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Не выбрано";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(498, 181);
            label8.Name = "label8";
            label8.Size = new Size(109, 19);
            label8.TabIndex = 15;
            label8.Text = "Кол-во продаж:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(498, 200);
            label9.Name = "label9";
            label9.Size = new Size(108, 19);
            label9.TabIndex = 16;
            label9.Text = "Сумма продаж:";
            // 
            // HistorySalesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 262);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(brandComboBox);
            Controls.Add(label6);
            Controls.Add(countryComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(backButton);
            Name = "HistorySalesList";
            Text = "HistorySalesList";
            FormClosing += HistorySalesList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private ComboBox brandComboBox;
        private Label label6;
        private ComboBox countryComboBox;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
    }
}