namespace CarSaloon.Cars
{
    partial class ClientsList
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
            dataGridView1 = new DataGridView();
            clientBindingSource = new BindingSource(components);
            backButton = new Button();
            label1 = new Label();
            nameTextBox = new TextBox();
            passportTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            adressTextBox = new TextBox();
            label4 = new Label();
            phoneTextBox = new TextBox();
            label6 = new Label();
            paymantComboBox = new ComboBox();
            deliveryCheckBox = new CheckBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(685, 283);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Models.Client);
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 388);
            backButton.Name = "backButton";
            backButton.Size = new Size(157, 30);
            backButton.TabIndex = 1;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 304);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "ФИО";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(52, 301);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(300, 23);
            nameTextBox.TabIndex = 3;
            // 
            // passportTextBox
            // 
            passportTextBox.Location = new Point(418, 301);
            passportTextBox.Name = "passportTextBox";
            passportTextBox.Size = new Size(279, 23);
            passportTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 304);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Паспорт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 333);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Оплата";
            // 
            // adressTextBox
            // 
            adressTextBox.Location = new Point(58, 359);
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(557, 23);
            adressTextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 362);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 8;
            label4.Text = "Адрес";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(73, 330);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(279, 23);
            phoneTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 333);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 12;
            label6.Text = "Телефон";
            // 
            // paymantComboBox
            // 
            paymantComboBox.FormattingEnabled = true;
            paymantComboBox.Items.AddRange(new object[] { "Наличный", "Безналичный" });
            paymantComboBox.Location = new Point(411, 330);
            paymantComboBox.Name = "paymantComboBox";
            paymantComboBox.Size = new Size(286, 23);
            paymantComboBox.TabIndex = 14;
            // 
            // deliveryCheckBox
            // 
            deliveryCheckBox.AutoSize = true;
            deliveryCheckBox.Location = new Point(621, 361);
            deliveryCheckBox.Name = "deliveryCheckBox";
            deliveryCheckBox.Size = new Size(76, 19);
            deliveryCheckBox.TabIndex = 15;
            deliveryCheckBox.Text = "Доставка";
            deliveryCheckBox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(175, 388);
            addButton.Name = "addButton";
            addButton.Size = new Size(170, 30);
            addButton.TabIndex = 16;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(351, 388);
            editButton.Name = "editButton";
            editButton.Size = new Size(170, 30);
            editButton.TabIndex = 17;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(527, 388);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(170, 30);
            deleteButton.TabIndex = 18;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // ClientsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 429);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(deliveryCheckBox);
            Controls.Add(paymantComboBox);
            Controls.Add(phoneTextBox);
            Controls.Add(label6);
            Controls.Add(adressTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passportTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(dataGridView1);
            Name = "ClientsList";
            Text = "ClientsList";
            FormClosing += ClientsList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button backButton;
        private Label label1;
        private TextBox nameTextBox;
        private TextBox passportTextBox;
        private Label label2;
        private Label label3;
        private TextBox adressTextBox;
        private Label label4;
        private TextBox phoneTextBox;
        private Label label6;
        private ComboBox paymantComboBox;
        private CheckBox deliveryCheckBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private BindingSource clientBindingSource;
    }
}