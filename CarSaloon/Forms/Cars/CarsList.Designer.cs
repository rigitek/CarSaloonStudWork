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
            cleanBrandButton = new Button();
            dataGridView1 = new DataGridView();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            label3 = new Label();
            bodyLabel = new Label();
            driveLabel = new Label();
            engineTypeLabel = new Label();
            transmissionLabel = new Label();
            doorsLabel = new Label();
            seatsLabel = new Label();
            horsePowerLabel = new Label();
            engineCapacityLabel = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(445, 16);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(197, 29);
            backButton.TabIndex = 0;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(77, 49);
            countryComboBox.Margin = new Padding(3, 4, 3, 4);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(114, 28);
            countryComboBox.TabIndex = 2;
            countryComboBox.Text = "Не выбрано";
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            countryComboBox.Click += countryComboBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 53);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Страна:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 53);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 5;
            label2.Text = "Производитель:";
            // 
            // brandComboBox
            // 
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(325, 49);
            brandComboBox.Margin = new Padding(3, 4, 3, 4);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(114, 28);
            brandComboBox.TabIndex = 4;
            brandComboBox.Text = "Не выбрано";
            brandComboBox.SelectedIndexChanged += brandComboBox_SelectedIndexChanged;
            brandComboBox.Click += brandComboBox_Click;
            // 
            // cleanBrandButton
            // 
            cleanBrandButton.Font = new Font("Segoe UI", 8F);
            cleanBrandButton.Location = new Point(445, 49);
            cleanBrandButton.Margin = new Padding(3, 4, 3, 4);
            cleanBrandButton.Name = "cleanBrandButton";
            cleanBrandButton.Size = new Size(197, 31);
            cleanBrandButton.TabIndex = 7;
            cleanBrandButton.Text = "Сброс";
            cleanBrandButton.UseVisualStyleBackColor = true;
            cleanBrandButton.Click += cleanBrandButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 88);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(629, 304);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // addButton
            // 
            addButton.Location = new Point(647, 256);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(235, 40);
            addButton.TabIndex = 10;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(647, 304);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(235, 40);
            editButton.TabIndex = 11;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(647, 352);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(235, 40);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(648, 17);
            label3.Name = "label3";
            label3.Size = new Size(246, 32);
            label3.TabIndex = 13;
            label3.Text = "Технические данные";
            // 
            // bodyLabel
            // 
            bodyLabel.AutoSize = true;
            bodyLabel.Font = new Font("Segoe UI", 10F);
            bodyLabel.Location = new Point(647, 49);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new Size(59, 23);
            bodyLabel.TabIndex = 14;
            bodyLabel.Text = "Кузов:";
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Font = new Font("Segoe UI", 10F);
            driveLabel.Location = new Point(647, 75);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(74, 23);
            driveLabel.TabIndex = 15;
            driveLabel.Text = "Привод:";
            // 
            // engineTypeLabel
            // 
            engineTypeLabel.AutoSize = true;
            engineTypeLabel.Font = new Font("Segoe UI", 10F);
            engineTypeLabel.Location = new Point(647, 100);
            engineTypeLabel.Name = "engineTypeLabel";
            engineTypeLabel.Size = new Size(126, 23);
            engineTypeLabel.TabIndex = 16;
            engineTypeLabel.Text = "Тип двигателя:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new Font("Segoe UI", 10F);
            transmissionLabel.Location = new Point(647, 125);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new Size(150, 23);
            transmissionLabel.TabIndex = 17;
            transmissionLabel.Text = "Тип трансмиссии:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Font = new Font("Segoe UI", 10F);
            doorsLabel.Location = new Point(647, 151);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new Size(130, 23);
            doorsLabel.TabIndex = 18;
            doorsLabel.Text = "Кол-во дверей:";
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Font = new Font("Segoe UI", 10F);
            seatsLabel.Location = new Point(647, 176);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new Size(110, 23);
            seatsLabel.TabIndex = 19;
            seatsLabel.Text = "Кол-во мест:";
            // 
            // horsePowerLabel
            // 
            horsePowerLabel.AutoSize = true;
            horsePowerLabel.Font = new Font("Segoe UI", 10F);
            horsePowerLabel.Location = new Point(647, 201);
            horsePowerLabel.Name = "horsePowerLabel";
            horsePowerLabel.Size = new Size(97, 23);
            horsePowerLabel.TabIndex = 20;
            horsePowerLabel.Text = "Мощность:";
            // 
            // engineCapacityLabel
            // 
            engineCapacityLabel.AutoSize = true;
            engineCapacityLabel.Font = new Font("Segoe UI", 10F);
            engineCapacityLabel.Location = new Point(647, 227);
            engineCapacityLabel.Name = "engineCapacityLabel";
            engineCapacityLabel.Size = new Size(151, 23);
            engineCapacityLabel.TabIndex = 21;
            engineCapacityLabel.Text = "Объем двигателя:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(14, 12);
            label4.Name = "label4";
            label4.Size = new Size(249, 32);
            label4.TabIndex = 22;
            label4.Text = "Список автомобилей";
            // 
            // CarsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 404);
            Controls.Add(label4);
            Controls.Add(engineCapacityLabel);
            Controls.Add(horsePowerLabel);
            Controls.Add(seatsLabel);
            Controls.Add(doorsLabel);
            Controls.Add(transmissionLabel);
            Controls.Add(engineTypeLabel);
            Controls.Add(driveLabel);
            Controls.Add(bodyLabel);
            Controls.Add(label3);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Controls.Add(cleanBrandButton);
            Controls.Add(label2);
            Controls.Add(brandComboBox);
            Controls.Add(label1);
            Controls.Add(countryComboBox);
            Controls.Add(backButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CarsList";
            Text = "CarsList";
            FormClosing += CarsList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private ComboBox countryComboBox;
        private Label label1;
        private Label label2;
        private ComboBox brandComboBox;
        private Button cleanBrandButton;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Label label3;
        private Label bodyLabel;
        private Label driveLabel;
        private Label engineTypeLabel;
        private Label doorsLabel;
        private Label seatsLabel;
        private Label horsePowerLabel;
        private Label engineCapacityLabel;
        public Label transmissionLabel;
        public DataGridView dataGridView1;
        private Label label4;
    }
}