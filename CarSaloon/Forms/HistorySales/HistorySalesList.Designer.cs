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
            fromDateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            toDateTimePicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            brandComboBox = new ComboBox();
            label7 = new Label();
            clientsComboBox = new ComboBox();
            amountSalesLabel = new Label();
            sumSalesLabel = new Label();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(569, 296);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(312, 40);
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
            dataGridView1.Location = new Point(14, 52);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(550, 284);
            dataGridView1.TabIndex = 2;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new Point(642, 55);
            fromDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(239, 27);
            fromDateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(570, 12);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 4;
            label1.Text = "Фильтрация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 60);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 5;
            label2.Text = "Дата с:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 99);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 7;
            label3.Text = "Дата по:";
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Location = new Point(642, 90);
            toDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(239, 27);
            toDateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(14, 12);
            label4.Name = "label4";
            label4.Size = new Size(167, 28);
            label4.TabIndex = 8;
            label4.Text = "История продаж";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 172);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 12;
            label5.Text = "Производитель:";
            // 
            // brandComboBox
            // 
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(697, 169);
            brandComboBox.Margin = new Padding(3, 4, 3, 4);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(184, 28);
            brandComboBox.TabIndex = 11;
            brandComboBox.Text = "Не выбрано";
            brandComboBox.Click += brandComboBox_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(570, 211);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 14;
            label7.Text = "Клиент:";
            // 
            // clientsComboBox
            // 
            clientsComboBox.FormattingEnabled = true;
            clientsComboBox.Location = new Point(637, 208);
            clientsComboBox.Margin = new Padding(3, 4, 3, 4);
            clientsComboBox.Name = "clientsComboBox";
            clientsComboBox.Size = new Size(244, 28);
            clientsComboBox.TabIndex = 13;
            clientsComboBox.Text = "Не выбрано";
            clientsComboBox.Click += clientsComboBox_Click;
            // 
            // amountSalesLabel
            // 
            amountSalesLabel.AutoSize = true;
            amountSalesLabel.Font = new Font("Segoe UI", 10F);
            amountSalesLabel.Location = new Point(569, 241);
            amountSalesLabel.Name = "amountSalesLabel";
            amountSalesLabel.Size = new Size(135, 23);
            amountSalesLabel.TabIndex = 15;
            amountSalesLabel.Text = "Кол-во продаж:";
            // 
            // sumSalesLabel
            // 
            sumSalesLabel.AutoSize = true;
            sumSalesLabel.Font = new Font("Segoe UI", 10F);
            sumSalesLabel.Location = new Point(569, 267);
            sumSalesLabel.Name = "sumSalesLabel";
            sumSalesLabel.Size = new Size(132, 23);
            sumSalesLabel.TabIndex = 16;
            sumSalesLabel.Text = "Сумма продаж:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(697, 13);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(184, 34);
            clearButton.TabIndex = 17;
            clearButton.Text = "Сброс";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // HistorySalesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 349);
            Controls.Add(clearButton);
            Controls.Add(sumSalesLabel);
            Controls.Add(amountSalesLabel);
            Controls.Add(label7);
            Controls.Add(clientsComboBox);
            Controls.Add(label5);
            Controls.Add(brandComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(toDateTimePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fromDateTimePicker);
            Controls.Add(dataGridView1);
            Controls.Add(backButton);
            Margin = new Padding(3, 4, 3, 4);
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
        private DateTimePicker fromDateTimePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker toDateTimePicker;
        private Label label4;
        private Label label5;
        private ComboBox brandComboBox;
        private Label label7;
        private ComboBox clientsComboBox;
        private Label amountSalesLabel;
        private Label sumSalesLabel;
        private Button clearButton;
    }
}