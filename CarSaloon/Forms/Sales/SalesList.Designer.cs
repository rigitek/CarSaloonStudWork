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
            label1 = new Label();
            label2 = new Label();
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
            deliveryLabel = new Label();
            addressLabel = new Label();
            passportLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(10, 408);
            backButton.Name = "backButton";
            backButton.Size = new Size(300, 30);
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
            clientsDataGridView.Location = new Point(10, 24);
            clientsDataGridView.Margin = new Padding(3, 2, 3, 2);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersWidth = 51;
            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsDataGridView.Size = new Size(320, 173);
            clientsDataGridView.TabIndex = 1;
            clientsDataGridView.CellClick += clientsDataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "Клиенты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 7);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Автомобили";
            // 
            // carsDataGridView
            // 
            carsDataGridView.AllowUserToAddRows = false;
            carsDataGridView.AllowUserToDeleteRows = false;
            carsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            carsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsDataGridView.Location = new Point(336, 24);
            carsDataGridView.Margin = new Padding(3, 2, 3, 2);
            carsDataGridView.Name = "carsDataGridView";
            carsDataGridView.ReadOnly = true;
            carsDataGridView.RowHeadersWidth = 51;
            carsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carsDataGridView.Size = new Size(328, 173);
            carsDataGridView.TabIndex = 3;
            carsDataGridView.CellClick += carsDataGridView_CellClick;
            // 
            // engineCapacityLabel
            // 
            engineCapacityLabel.AutoSize = true;
            engineCapacityLabel.Font = new Font("Segoe UI", 10F);
            engineCapacityLabel.Location = new Point(336, 332);
            engineCapacityLabel.Name = "engineCapacityLabel";
            engineCapacityLabel.Size = new Size(122, 19);
            engineCapacityLabel.TabIndex = 29;
            engineCapacityLabel.Text = "Объем двигателя:";
            // 
            // horsePowerLabel
            // 
            horsePowerLabel.AutoSize = true;
            horsePowerLabel.Font = new Font("Segoe UI", 10F);
            horsePowerLabel.Location = new Point(336, 313);
            horsePowerLabel.Name = "horsePowerLabel";
            horsePowerLabel.Size = new Size(80, 19);
            horsePowerLabel.TabIndex = 28;
            horsePowerLabel.Text = "Мощность:";
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Font = new Font("Segoe UI", 10F);
            seatsLabel.Location = new Point(336, 294);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new Size(89, 19);
            seatsLabel.TabIndex = 27;
            seatsLabel.Text = "Кол-во мест:";
            // 
            // doorsLabel
            // 
            doorsLabel.AutoSize = true;
            doorsLabel.Font = new Font("Segoe UI", 10F);
            doorsLabel.Location = new Point(336, 275);
            doorsLabel.Name = "doorsLabel";
            doorsLabel.Size = new Size(105, 19);
            doorsLabel.TabIndex = 26;
            doorsLabel.Text = "Кол-во дверей:";
            // 
            // transmissionLabel
            // 
            transmissionLabel.AutoSize = true;
            transmissionLabel.Font = new Font("Segoe UI", 10F);
            transmissionLabel.Location = new Point(336, 256);
            transmissionLabel.Name = "transmissionLabel";
            transmissionLabel.Size = new Size(93, 19);
            transmissionLabel.TabIndex = 25;
            transmissionLabel.Text = "Трансмиссия:";
            // 
            // engineTypeLabel
            // 
            engineTypeLabel.AutoSize = true;
            engineTypeLabel.Font = new Font("Segoe UI", 10F);
            engineTypeLabel.Location = new Point(336, 237);
            engineTypeLabel.Name = "engineTypeLabel";
            engineTypeLabel.Size = new Size(76, 19);
            engineTypeLabel.TabIndex = 24;
            engineTypeLabel.Text = "Двигатель:";
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Font = new Font("Segoe UI", 10F);
            driveLabel.Location = new Point(336, 218);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(61, 19);
            driveLabel.TabIndex = 23;
            driveLabel.Text = "Привод:";
            // 
            // bodyLabel
            // 
            bodyLabel.AutoSize = true;
            bodyLabel.Font = new Font("Segoe UI", 10F);
            bodyLabel.Location = new Point(336, 199);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new Size(48, 19);
            bodyLabel.TabIndex = 22;
            bodyLabel.Text = "Кузов:";
            // 
            // paymantLabel
            // 
            paymantLabel.AutoSize = true;
            paymantLabel.Font = new Font("Segoe UI", 10F);
            paymantLabel.Location = new Point(10, 256);
            paymantLabel.Name = "paymantLabel";
            paymantLabel.Size = new Size(59, 19);
            paymantLabel.TabIndex = 33;
            paymantLabel.Text = "Платеж:";
            // 
            // deliveryLabel
            // 
            deliveryLabel.AutoSize = true;
            deliveryLabel.Font = new Font("Segoe UI", 10F);
            deliveryLabel.Location = new Point(10, 237);
            deliveryLabel.Name = "deliveryLabel";
            deliveryLabel.Size = new Size(70, 19);
            deliveryLabel.TabIndex = 32;
            deliveryLabel.Text = "Доставка:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 10F);
            addressLabel.Location = new Point(10, 218);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(50, 19);
            addressLabel.TabIndex = 31;
            addressLabel.Text = "Адрес:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Font = new Font("Segoe UI", 10F);
            passportLabel.Location = new Point(10, 199);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new Size(65, 19);
            passportLabel.TabIndex = 30;
            passportLabel.Text = "Паспорт:";
            // 
            // SalesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(paymantLabel);
            Controls.Add(deliveryLabel);
            Controls.Add(addressLabel);
            Controls.Add(passportLabel);
            Controls.Add(engineCapacityLabel);
            Controls.Add(horsePowerLabel);
            Controls.Add(seatsLabel);
            Controls.Add(doorsLabel);
            Controls.Add(transmissionLabel);
            Controls.Add(engineTypeLabel);
            Controls.Add(driveLabel);
            Controls.Add(bodyLabel);
            Controls.Add(label2);
            Controls.Add(carsDataGridView);
            Controls.Add(label1);
            Controls.Add(clientsDataGridView);
            Controls.Add(backButton);
            Name = "SalesList";
            Text = "SalesList";
            FormClosing += SalesList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)carsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private DataGridView clientsDataGridView;
        private Label label1;
        private Label label2;
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
        private Label deliveryLabel;
        private Label addressLabel;
        private Label passportLabel;
    }
}