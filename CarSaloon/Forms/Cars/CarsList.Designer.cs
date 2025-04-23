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
            filterButton = new Button();
            steeringLabel = new Label();
            ABSLabel = new Label();
            ACLabel = new Label();
            multimediaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(618, 337);
            backButton.Name = "backButton";
            backButton.Size = new Size(185, 30);
            backButton.TabIndex = 0;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // cleanBrandButton
            // 
            cleanBrandButton.Font = new Font("Segoe UI", 8F);
            cleanBrandButton.Location = new Point(618, 301);
            cleanBrandButton.Name = "cleanBrandButton";
            cleanBrandButton.Size = new Size(185, 30);
            cleanBrandButton.TabIndex = 7;
            cleanBrandButton.Text = "Сброс фильтра";
            cleanBrandButton.UseVisualStyleBackColor = true;
            cleanBrandButton.Click += cleanBrandButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(600, 294);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 337);
            addButton.Name = "addButton";
            addButton.Size = new Size(196, 30);
            addButton.TabIndex = 10;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(214, 337);
            editButton.Name = "editButton";
            editButton.Size = new Size(196, 30);
            editButton.TabIndex = 11;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(416, 337);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(196, 30);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(618, 9);
            label3.Name = "label3";
            label3.Size = new Size(193, 25);
            label3.TabIndex = 13;
            label3.Text = "Технические данные";
            // 
            // bodyLabel
            // 
            bodyLabel.AutoSize = true;
            bodyLabel.Font = new Font("Segoe UI", 10F);
            bodyLabel.Location = new Point(618, 34);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new Size(48, 19);
            bodyLabel.TabIndex = 14;
            bodyLabel.Text = "Кузов:";
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Font = new Font("Segoe UI", 10F);
            driveLabel.Location = new Point(618, 53);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(61, 19);
            driveLabel.TabIndex = 15;
            driveLabel.Text = "Привод:";
            // 
            // engineTypeLabel
            // 
            engineTypeLabel.AutoSize = true;
            engineTypeLabel.Font = new Font("Segoe UI", 10F);
            engineTypeLabel.Location = new Point(618, 72);
            engineTypeLabel.Name = "engineTypeLabel";
            engineTypeLabel.Size = new Size(101, 19);
            engineTypeLabel.TabIndex = 16;
            engineTypeLabel.Text = "Тип двигателя:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new Font("Segoe UI", 10F);
            transmissionLabel.Location = new Point(618, 91);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new Size(120, 19);
            transmissionLabel.TabIndex = 17;
            transmissionLabel.Text = "Тип трансмиссии:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Font = new Font("Segoe UI", 10F);
            doorsLabel.Location = new Point(618, 110);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new Size(105, 19);
            doorsLabel.TabIndex = 18;
            doorsLabel.Text = "Кол-во дверей:";
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Font = new Font("Segoe UI", 10F);
            seatsLabel.Location = new Point(618, 129);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new Size(89, 19);
            seatsLabel.TabIndex = 19;
            seatsLabel.Text = "Кол-во мест:";
            // 
            // horsePowerLabel
            // 
            horsePowerLabel.AutoSize = true;
            horsePowerLabel.Font = new Font("Segoe UI", 10F);
            horsePowerLabel.Location = new Point(618, 148);
            horsePowerLabel.Name = "horsePowerLabel";
            horsePowerLabel.Size = new Size(80, 19);
            horsePowerLabel.TabIndex = 20;
            horsePowerLabel.Text = "Мощность:";
            // 
            // engineCapacityLabel
            // 
            engineCapacityLabel.AutoSize = true;
            engineCapacityLabel.Font = new Font("Segoe UI", 10F);
            engineCapacityLabel.Location = new Point(618, 167);
            engineCapacityLabel.Name = "engineCapacityLabel";
            engineCapacityLabel.Size = new Size(122, 19);
            engineCapacityLabel.TabIndex = 21;
            engineCapacityLabel.Text = "Объем двигателя:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 22;
            label4.Text = "Список автомобилей";
            // 
            // filterButton
            // 
            filterButton.Font = new Font("Segoe UI", 8F);
            filterButton.Location = new Point(618, 265);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(185, 30);
            filterButton.TabIndex = 23;
            filterButton.Text = "Фильтрация";
            filterButton.UseVisualStyleBackColor = true;
            // 
            // steeringLabel
            // 
            steeringLabel.AutoSize = true;
            steeringLabel.Font = new Font("Segoe UI", 10F);
            steeringLabel.Location = new Point(618, 186);
            steeringLabel.Name = "steeringLabel";
            steeringLabel.Size = new Size(41, 19);
            steeringLabel.TabIndex = 24;
            steeringLabel.Text = "Руль:";
            // 
            // ABSLabel
            // 
            ABSLabel.AutoSize = true;
            ABSLabel.Font = new Font("Segoe UI", 10F);
            ABSLabel.Location = new Point(618, 205);
            ABSLabel.Name = "ABSLabel";
            ABSLabel.Size = new Size(36, 19);
            ABSLabel.TabIndex = 26;
            ABSLabel.Text = "ABS:";
            // 
            // ACLabel
            // 
            ACLabel.AutoSize = true;
            ACLabel.Font = new Font("Segoe UI", 10F);
            ACLabel.Location = new Point(618, 224);
            ACLabel.Name = "ACLabel";
            ACLabel.Size = new Size(99, 19);
            ACLabel.TabIndex = 27;
            ACLabel.Text = "Кондиционер:";
            // 
            // multimediaLabel
            // 
            multimediaLabel.AutoSize = true;
            multimediaLabel.Font = new Font("Segoe UI", 10F);
            multimediaLabel.Location = new Point(618, 243);
            multimediaLabel.Name = "multimediaLabel";
            multimediaLabel.Size = new Size(100, 19);
            multimediaLabel.TabIndex = 28;
            multimediaLabel.Text = "Мультимедиа:";
            // 
            // CarsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 374);
            Controls.Add(multimediaLabel);
            Controls.Add(ACLabel);
            Controls.Add(ABSLabel);
            Controls.Add(steeringLabel);
            Controls.Add(filterButton);
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
            Controls.Add(backButton);
            Name = "CarsList";
            Text = "Список автомобилей";
            FormClosing += CarsList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
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
        private Button filterButton;
        private Label steeringLabel;
        private Label ABSLabel;
        private Label ACLabel;
        private Label multimediaLabel;
    }
}