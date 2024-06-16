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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            brandComboBox = new ComboBox();
            label7 = new Label();
            clientsComboBox = new ComboBox();
            amountSalesLabeltext = new Label();
            sumSalesLabeltext = new Label();
            clearButton = new Button();
            amountSales = new Label();
            sumSales = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(499, 220);
            backButton.Name = "backButton";
            backButton.Size = new Size(273, 30);
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
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 213);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(499, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 4;
            label1.Text = "Фильтрация";
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
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(499, 39);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 12;
            label5.Text = "Производитель:";
            // 
            // brandComboBox
            // 
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(612, 38);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(159, 23);
            brandComboBox.TabIndex = 11;
            brandComboBox.Text = "Не выбрано";
            brandComboBox.SelectedIndexChanged += brandComboBox_SelectedIndexChanged;
            brandComboBox.Click += brandComboBox_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(499, 68);
            label7.Name = "label7";
            label7.Size = new Size(56, 19);
            label7.TabIndex = 14;
            label7.Text = "Клиент:";
            // 
            // clientsComboBox
            // 
            clientsComboBox.FormattingEnabled = true;
            clientsComboBox.Location = new Point(561, 67);
            clientsComboBox.Name = "clientsComboBox";
            clientsComboBox.Size = new Size(211, 23);
            clientsComboBox.TabIndex = 13;
            clientsComboBox.Text = "Не выбрано";
            clientsComboBox.SelectedIndexChanged += clientsComboBox_SelectedIndexChanged;
            clientsComboBox.Click += clientsComboBox_Click;
            // 
            // amountSalesLabeltext
            // 
            amountSalesLabeltext.AutoSize = true;
            amountSalesLabeltext.Font = new Font("Segoe UI", 10F);
            amountSalesLabeltext.Location = new Point(499, 93);
            amountSalesLabeltext.Name = "amountSalesLabeltext";
            amountSalesLabeltext.Size = new Size(109, 19);
            amountSalesLabeltext.TabIndex = 15;
            amountSalesLabeltext.Text = "Кол-во продаж:";
            // 
            // sumSalesLabeltext
            // 
            sumSalesLabeltext.AutoSize = true;
            sumSalesLabeltext.Font = new Font("Segoe UI", 10F);
            sumSalesLabeltext.Location = new Point(499, 112);
            sumSalesLabeltext.Name = "sumSalesLabeltext";
            sumSalesLabeltext.Size = new Size(108, 19);
            sumSalesLabeltext.TabIndex = 16;
            sumSalesLabeltext.Text = "Сумма продаж:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(499, 184);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(272, 30);
            clearButton.TabIndex = 17;
            clearButton.Text = "Сброс";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // amountSales
            // 
            amountSales.AutoSize = true;
            amountSales.Font = new Font("Segoe UI", 10F);
            amountSales.Location = new Point(615, 93);
            amountSales.Name = "amountSales";
            amountSales.Size = new Size(0, 19);
            amountSales.TabIndex = 18;
            // 
            // sumSales
            // 
            sumSales.AutoSize = true;
            sumSales.Font = new Font("Segoe UI", 10F);
            sumSales.Location = new Point(614, 112);
            sumSales.Name = "sumSales";
            sumSales.Size = new Size(0, 19);
            sumSales.TabIndex = 19;
            // 
            // HistorySalesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 262);
            Controls.Add(sumSales);
            Controls.Add(amountSales);
            Controls.Add(clearButton);
            Controls.Add(sumSalesLabeltext);
            Controls.Add(amountSalesLabeltext);
            Controls.Add(label7);
            Controls.Add(clientsComboBox);
            Controls.Add(label5);
            Controls.Add(brandComboBox);
            Controls.Add(label4);
            Controls.Add(label1);
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
        private Label label1;
        private Label label4;
        private Label label5;
        private ComboBox brandComboBox;
        private Label label7;
        private ComboBox clientsComboBox;
        private Label amountSalesLabeltext;
        private Label sumSalesLabeltext;
        private Button clearButton;
        private Label amountSales;
        private Label sumSales;
    }
}