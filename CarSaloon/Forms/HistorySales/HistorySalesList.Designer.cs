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
            deleteButton = new Button();
            label2 = new Label();
            employeeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(530, 236);
            backButton.Name = "backButton";
            backButton.Size = new Size(262, 30);
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(512, 227);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(516, 9);
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
            label5.Location = new Point(530, 39);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 12;
            label5.Text = "Производитель:";
            // 
            // brandComboBox
            // 
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(646, 39);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(146, 23);
            brandComboBox.TabIndex = 11;
            brandComboBox.Text = "Не выбрано";
            brandComboBox.SelectedIndexChanged += brandComboBox_SelectedIndexChanged;
            brandComboBox.Click += brandComboBox_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(530, 69);
            label7.Name = "label7";
            label7.Size = new Size(56, 19);
            label7.TabIndex = 14;
            label7.Text = "Клиент:";
            // 
            // clientsComboBox
            // 
            clientsComboBox.FormattingEnabled = true;
            clientsComboBox.Location = new Point(592, 68);
            clientsComboBox.Name = "clientsComboBox";
            clientsComboBox.Size = new Size(200, 23);
            clientsComboBox.TabIndex = 13;
            clientsComboBox.Text = "Не выбрано";
            clientsComboBox.SelectedIndexChanged += clientsComboBox_SelectedIndexChanged;
            clientsComboBox.Click += clientsComboBox_Click;
            // 
            // amountSalesLabeltext
            // 
            amountSalesLabeltext.AutoSize = true;
            amountSalesLabeltext.Font = new Font("Segoe UI", 10F);
            amountSalesLabeltext.Location = new Point(530, 123);
            amountSalesLabeltext.Name = "amountSalesLabeltext";
            amountSalesLabeltext.Size = new Size(109, 19);
            amountSalesLabeltext.TabIndex = 15;
            amountSalesLabeltext.Text = "Кол-во продаж:";
            // 
            // sumSalesLabeltext
            // 
            sumSalesLabeltext.AutoSize = true;
            sumSalesLabeltext.Font = new Font("Segoe UI", 10F);
            sumSalesLabeltext.Location = new Point(530, 142);
            sumSalesLabeltext.Name = "sumSalesLabeltext";
            sumSalesLabeltext.Size = new Size(108, 19);
            sumSalesLabeltext.TabIndex = 16;
            sumSalesLabeltext.Text = "Сумма продаж:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(530, 200);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(262, 30);
            clearButton.TabIndex = 17;
            clearButton.Text = "Сброс фильтра";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // amountSales
            // 
            amountSales.AutoSize = true;
            amountSales.Font = new Font("Segoe UI", 10F);
            amountSales.Location = new Point(647, 123);
            amountSales.Name = "amountSales";
            amountSales.Size = new Size(0, 19);
            amountSales.TabIndex = 18;
            // 
            // sumSales
            // 
            sumSales.AutoSize = true;
            sumSales.Font = new Font("Segoe UI", 10F);
            sumSales.Location = new Point(646, 142);
            sumSales.Name = "sumSales";
            sumSales.Size = new Size(0, 19);
            sumSales.TabIndex = 19;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(530, 164);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(262, 30);
            deleteButton.TabIndex = 20;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(530, 98);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 21;
            label2.Text = "Сотрудник:";
            // 
            // employeeComboBox
            // 
            employeeComboBox.FormattingEnabled = true;
            employeeComboBox.Location = new Point(614, 97);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Size = new Size(178, 23);
            employeeComboBox.TabIndex = 22;
            employeeComboBox.Text = "Не выбрано";
            employeeComboBox.SelectedIndexChanged += employeeComboBox_SelectedIndexChanged;
            employeeComboBox.Click += employeeComboBox_Click;
            // 
            // HistorySalesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 278);
            Controls.Add(employeeComboBox);
            Controls.Add(label2);
            Controls.Add(deleteButton);
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
            Text = "История продаж";
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
        private Button deleteButton;
        private Label label2;
        private ComboBox employeeComboBox;
    }
}