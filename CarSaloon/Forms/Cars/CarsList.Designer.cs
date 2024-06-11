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
            components = new System.ComponentModel.Container();
            backButton = new Button();
            countryComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            brandComboBox = new ComboBox();
            cleanCountryButton = new Button();
            cleanBrandButton = new Button();
            dataGridView1 = new DataGridView();
            carBindingSource = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(568, 319);
            backButton.Name = "backButton";
            backButton.Size = new Size(204, 30);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(550, 289);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Models.Car);
            // 
            // addButton
            // 
            addButton.Location = new Point(282, 26);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(378, 26);
            editButton.Name = "editButton";
            editButton.Size = new Size(90, 23);
            editButton.TabIndex = 11;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(474, 26);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(90, 23);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(570, 21);
            label3.Name = "label3";
            label3.Size = new Size(201, 28);
            label3.TabIndex = 13;
            label3.Text = "Технические данные";
            // 
            // bodyLabel
            // 
            bodyLabel.AutoSize = true;
            bodyLabel.Font = new Font("Segoe UI", 10F);
            bodyLabel.Location = new Point(568, 60);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new Size(48, 19);
            bodyLabel.TabIndex = 14;
            bodyLabel.Text = "Кузов:";
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Font = new Font("Segoe UI", 10F);
            driveLabel.Location = new Point(568, 79);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(61, 19);
            driveLabel.TabIndex = 15;
            driveLabel.Text = "Привод:";
            // 
            // engineTypeLabel
            // 
            engineTypeLabel.AutoSize = true;
            engineTypeLabel.Font = new Font("Segoe UI", 10F);
            engineTypeLabel.Location = new Point(568, 98);
            engineTypeLabel.Name = "engineTypeLabel";
            engineTypeLabel.Size = new Size(101, 19);
            engineTypeLabel.TabIndex = 16;
            engineTypeLabel.Text = "Тип двигателя:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new Font("Segoe UI", 10F);
            transmissionLabel.Location = new Point(568, 117);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new Size(120, 19);
            transmissionLabel.TabIndex = 17;
            transmissionLabel.Text = "Тип трансмиссии:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Font = new Font("Segoe UI", 10F);
            doorsLabel.Location = new Point(568, 136);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new Size(105, 19);
            doorsLabel.TabIndex = 18;
            doorsLabel.Text = "Кол-во дверей:";
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Font = new Font("Segoe UI", 10F);
            seatsLabel.Location = new Point(568, 155);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new Size(89, 19);
            seatsLabel.TabIndex = 19;
            seatsLabel.Text = "Кол-во мест:";
            // 
            // horsePowerLabel
            // 
            horsePowerLabel.AutoSize = true;
            horsePowerLabel.Font = new Font("Segoe UI", 10F);
            horsePowerLabel.Location = new Point(568, 174);
            horsePowerLabel.Name = "horsePowerLabel";
            horsePowerLabel.Size = new Size(80, 19);
            horsePowerLabel.TabIndex = 20;
            horsePowerLabel.Text = "Мощность:";
            // 
            // engineCapacityLabel
            // 
            engineCapacityLabel.AutoSize = true;
            engineCapacityLabel.Font = new Font("Segoe UI", 10F);
            engineCapacityLabel.Location = new Point(568, 193);
            engineCapacityLabel.Name = "engineCapacityLabel";
            engineCapacityLabel.Size = new Size(122, 19);
            engineCapacityLabel.TabIndex = 21;
            engineCapacityLabel.Text = "Объем двигателя:";
            // 
            // CarsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
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
            Controls.Add(cleanCountryButton);
            Controls.Add(label2);
            Controls.Add(brandComboBox);
            Controls.Add(label1);
            Controls.Add(countryComboBox);
            Controls.Add(backButton);
            Name = "CarsList";
            Text = "CarsList";
            FormClosing += CarsList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
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
        private DataGridView dataGridView1;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Label label3;
        private Label bodyLabel;
        private Label driveLabel;
        private BindingSource carBindingSource;
        private Label engineTypeLabel;
        private Label transmissionLabel;
        private Label doorsLabel;
        private Label seatsLabel;
        private Label horsePowerLabel;
        private Label engineCapacityLabel;
    }
}