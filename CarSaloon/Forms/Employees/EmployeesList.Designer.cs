namespace CarSaloon.Forms.Employees
{
    partial class EmployeesList
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            backButton = new Button();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            cleanButton = new Button();
            label3 = new Label();
            loginTextBox = new TextBox();
            label4 = new Label();
            passwordTextBox = new TextBox();
            postComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(660, 218);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 236);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "ФИО";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(52, 233);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(170, 23);
            nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 236);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Должность";
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 262);
            backButton.Name = "backButton";
            backButton.Size = new Size(127, 23);
            backButton.TabIndex = 5;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(145, 262);
            addButton.Name = "addButton";
            addButton.Size = new Size(127, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(278, 262);
            editButton.Name = "editButton";
            editButton.Size = new Size(127, 23);
            editButton.TabIndex = 7;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(411, 262);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(127, 23);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // cleanButton
            // 
            cleanButton.Location = new Point(545, 262);
            cleanButton.Name = "cleanButton";
            cleanButton.Size = new Size(127, 23);
            cleanButton.TabIndex = 9;
            cleanButton.Text = "Очистить";
            cleanButton.UseVisualStyleBackColor = true;
            cleanButton.Click += cleanButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 236);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 10;
            label3.Text = "Логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(471, 233);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(70, 23);
            loginTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 236);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 12;
            label4.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(602, 233);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(70, 23);
            passwordTextBox.TabIndex = 13;
            // 
            // postComboBox
            // 
            postComboBox.FormattingEnabled = true;
            postComboBox.Items.AddRange(new object[] { "Администратор", "Менеджер", "Продавец" });
            postComboBox.Location = new Point(303, 233);
            postComboBox.Name = "postComboBox";
            postComboBox.RightToLeft = RightToLeft.No;
            postComboBox.Size = new Size(115, 23);
            postComboBox.TabIndex = 14;
            postComboBox.Text = "Выбрать";
            // 
            // EmployeesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 294);
            Controls.Add(postComboBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label4);
            Controls.Add(loginTextBox);
            Controls.Add(label3);
            Controls.Add(cleanButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(backButton);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "EmployeesList";
            Text = "Список сотрудников";
            FormClosing += EmployeesList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private Button backButton;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button cleanButton;
        private Label label3;
        private TextBox loginTextBox;
        private Label label4;
        private TextBox passwordTextBox;
        private ComboBox postComboBox;
    }
}