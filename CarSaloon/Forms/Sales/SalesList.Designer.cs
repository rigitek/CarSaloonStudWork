namespace CarSaloon.Forms.Sales
{
    partial class SalesList
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
            clientsDataGridView = new DataGridView();
            carsDataGridView = new DataGridView();
            engineCapacityLabel = new Label();
            horsePowerLabel = new Label();
            seatsLabel = new Label();
            doorsLabel = new Label();
            transmissionLabel = new Label();
            engineTypeLabel = new Label();
            driveLabel = new Label();
            bodyLabel = new Label();
            paymantLabel = new Label();
            addressLabel = new Label();
            passportLabel = new Label();
            button1 = new Button();
            phoneLabel = new Label();
            nameLabel = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            steeringLabel = new Label();
            multimediaLabel = new Label();
            ACLabel = new Label();
            ABSLabel = new Label();
            paymentComboBox = new ComboBox();
            employeeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carsDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(10, 333);
            backButton.Name = "backButton";
            backButton.Size = new Size(321, 30);
            backButton.TabIndex = 0;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.AllowUserToAddRows = false;
            clientsDataGridView.AllowUserToDeleteRows = false;
            clientsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Location = new Point(16, 33);
            clientsDataGridView.Margin = new Padding(3, 2, 3, 2);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersWidth = 51;
            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsDataGridView.Size = new Size(308, 164);
            clientsDataGridView.TabIndex = 1;
            clientsDataGridView.CellClick += clientsDataGridView_CellClick;
            // 
            // carsDataGridView
            // 
            carsDataGridView.AllowUserToAddRows = false;
            carsDataGridView.AllowUserToDeleteRows = false;
            carsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            carsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsDataGridView.Location = new Point(6, 21);
            carsDataGridView.Margin = new Padding(3, 2, 3, 2);
            carsDataGridView.Name = "carsDataGridView";
            carsDataGridView.ReadOnly = true;
            carsDataGridView.RowHeadersWidth = 51;
            carsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsDataGridView.Size = new Size(388, 164);
            carsDataGridView.TabIndex = 3;
            carsDataGridView.CellClick += carsDataGridView_CellClick;
            // 
            // engineCapacityLabel
            // 
            engineCapacityLabel.AutoSize = true;
            engineCapacityLabel.Font = new Font("Segoe UI", 10F);
            engineCapacityLabel.Location = new Point(202, 244);
            engineCapacityLabel.Name = "engineCapacityLabel";
            engineCapacityLabel.Size = new Size(122, 19);
            engineCapacityLabel.TabIndex = 29;
            engineCapacityLabel.Text = "Объем двигателя:";
            // 
            // horsePowerLabel
            // 
            horsePowerLabel.AutoSize = true;
            horsePowerLabel.Font = new Font("Segoe UI", 10F);
            horsePowerLabel.Location = new Point(538, 237);
            horsePowerLabel.Name = "horsePowerLabel";
            horsePowerLabel.Size = new Size(80, 19);
            horsePowerLabel.TabIndex = 28;
            horsePowerLabel.Text = "Мощность:";
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Font = new Font("Segoe UI", 10F);
            seatsLabel.Location = new Point(538, 218);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new Size(89, 19);
            seatsLabel.TabIndex = 27;
            seatsLabel.Text = "Кол-во мест:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Font = new Font("Segoe UI", 10F);
            doorsLabel.Location = new Point(538, 199);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new Size(105, 19);
            doorsLabel.TabIndex = 26;
            doorsLabel.Text = "Кол-во дверей:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new Font("Segoe UI", 10F);
            transmissionLabel.Location = new Point(6, 244);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new Size(93, 19);
            transmissionLabel.TabIndex = 25;
            transmissionLabel.Text = "Трансмиссия:";
            // 
            // engineTypeLabel
            // 
            engineTypeLabel.AutoSize = true;
            engineTypeLabel.Font = new Font("Segoe UI", 10F);
            engineTypeLabel.Location = new Point(6, 225);
            engineTypeLabel.Name = "engineTypeLabel";
            engineTypeLabel.Size = new Size(76, 19);
            engineTypeLabel.TabIndex = 24;
            engineTypeLabel.Text = "Двигатель:";
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Font = new Font("Segoe UI", 10F);
            driveLabel.Location = new Point(6, 206);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(61, 19);
            driveLabel.TabIndex = 23;
            driveLabel.Text = "Привод:";
            // 
            // bodyLabel
            // 
            bodyLabel.AutoSize = true;
            bodyLabel.Font = new Font("Segoe UI", 10F);
            bodyLabel.Location = new Point(6, 187);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new Size(48, 19);
            bodyLabel.TabIndex = 22;
            bodyLabel.Text = "Кузов:";
            // 
            // paymantLabel
            // 
            paymantLabel.AutoSize = true;
            paymantLabel.Font = new Font("Segoe UI", 10F);
            paymantLabel.Location = new Point(10, 285);
            paymantLabel.Name = "paymantLabel";
            paymantLabel.Size = new Size(59, 19);
            paymantLabel.TabIndex = 33;
            paymantLabel.Text = "Платеж:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 10F);
            addressLabel.Location = new Point(6, 244);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(50, 19);
            addressLabel.TabIndex = 31;
            addressLabel.Text = "Адрес:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Font = new Font("Segoe UI", 10F);
            passportLabel.Location = new Point(6, 225);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new Size(65, 19);
            passportLabel.TabIndex = 30;
            passportLabel.Text = "Паспорт:";
            // 
            // button1
            // 
            button1.Location = new Point(336, 321);
            button1.Name = "button1";
            button1.Size = new Size(400, 41);
            button1.TabIndex = 34;
            button1.Text = "Оформить продажу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 10F);
            phoneLabel.Location = new Point(6, 206);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(66, 19);
            phoneLabel.TabIndex = 36;
            phoneLabel.Text = "Телефон:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10F);
            nameLabel.Location = new Point(6, 187);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(43, 19);
            nameLabel.TabIndex = 35;
            nameLabel.Text = "ФИО:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 311);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 37;
            label3.Text = "Ответственный:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(phoneLabel);
            groupBox1.Controls.Add(passportLabel);
            groupBox1.Controls.Add(addressLabel);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 265);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Клиенты";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(steeringLabel);
            groupBox2.Controls.Add(multimediaLabel);
            groupBox2.Controls.Add(ACLabel);
            groupBox2.Controls.Add(ABSLabel);
            groupBox2.Controls.Add(bodyLabel);
            groupBox2.Controls.Add(driveLabel);
            groupBox2.Controls.Add(engineTypeLabel);
            groupBox2.Controls.Add(engineCapacityLabel);
            groupBox2.Controls.Add(transmissionLabel);
            groupBox2.Controls.Add(carsDataGridView);
            groupBox2.Location = new Point(336, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 303);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Автомобили";
            // 
            // steeringLabel
            // 
            steeringLabel.AutoSize = true;
            steeringLabel.Font = new Font("Segoe UI", 10F);
            steeringLabel.Location = new Point(6, 263);
            steeringLabel.Name = "steeringLabel";
            steeringLabel.Size = new Size(41, 19);
            steeringLabel.TabIndex = 34;
            steeringLabel.Text = "Руль:";
            // 
            // multimediaLabel
            // 
            multimediaLabel.AutoSize = true;
            multimediaLabel.Font = new Font("Segoe UI", 10F);
            multimediaLabel.Location = new Point(202, 282);
            multimediaLabel.Name = "multimediaLabel";
            multimediaLabel.Size = new Size(100, 19);
            multimediaLabel.TabIndex = 33;
            multimediaLabel.Text = "Мультимедиа:";
            // 
            // ACLabel
            // 
            ACLabel.AutoSize = true;
            ACLabel.Font = new Font("Segoe UI", 10F);
            ACLabel.Location = new Point(202, 263);
            ACLabel.Name = "ACLabel";
            ACLabel.Size = new Size(99, 19);
            ACLabel.TabIndex = 31;
            ACLabel.Text = "Кондиционер:";
            // 
            // ABSLabel
            // 
            ABSLabel.AutoSize = true;
            ABSLabel.Font = new Font("Segoe UI", 10F);
            ABSLabel.Location = new Point(6, 282);
            ABSLabel.Name = "ABSLabel";
            ABSLabel.Size = new Size(36, 19);
            ABSLabel.TabIndex = 30;
            ABSLabel.Text = "ABS:";
            // 
            // paymentComboBox
            // 
            paymentComboBox.FormattingEnabled = true;
            paymentComboBox.Items.AddRange(new object[] { "Наличный", "Безналичный", "Кредит" });
            paymentComboBox.Location = new Point(75, 281);
            paymentComboBox.Name = "paymentComboBox";
            paymentComboBox.Size = new Size(255, 23);
            paymentComboBox.TabIndex = 40;
            // 
            // employeeComboBox
            // 
            employeeComboBox.FormattingEnabled = true;
            employeeComboBox.Location = new Point(127, 307);
            employeeComboBox.Name = "employeeComboBox";
            employeeComboBox.Size = new Size(204, 23);
            employeeComboBox.TabIndex = 41;
            // 
            // SalesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 369);
            Controls.Add(employeeComboBox);
            Controls.Add(paymentComboBox);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(paymantLabel);
            Controls.Add(horsePowerLabel);
            Controls.Add(seatsLabel);
            Controls.Add(doorsLabel);
            Controls.Add(clientsDataGridView);
            Controls.Add(backButton);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "SalesList";
            Text = "Продажи";
            FormClosing += SalesList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)carsDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private DataGridView clientsDataGridView;
        private DataGridView carsDataGridView;
        private Label engineCapacityLabel;
        private Label horsePowerLabel;
        private Label seatsLabel;
        private Label doorsLabel;
        public Label transmissionLabel;
        private Label engineTypeLabel;
        private Label driveLabel;
        private Label bodyLabel;
        public Label paymantLabel;
        private Label addressLabel;
        private Label passportLabel;
        private Button button1;
        private Label phoneLabel;
        private Label nameLabel;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox paymentComboBox;
        private ComboBox employeeComboBox;
        public Label steeringLabel;
        public Label multimediaLabel;
        public Label ACLabel;
        public Label ABSLabel;
    }
}