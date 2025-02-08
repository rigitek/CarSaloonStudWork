namespace CarSaloon.Forms.Cars
{
    partial class AddCar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            availableCheckBox = new CheckBox();
            modelTextBox = new TextBox();
            priceTextBox = new TextBox();
            countryComboBox = new ComboBox();
            brandComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            doorsNumericUpDown = new NumericUpDown();
            seatsNumericUpDown = new NumericUpDown();
            engineCapacityNumericUpDown = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            horsePowerTextBox = new TextBox();
            transmissionComboBox = new ComboBox();
            engineTypeComboBox = new ComboBox();
            label9 = new Label();
            label4 = new Label();
            driveComboBox = new ComboBox();
            label8 = new Label();
            bodyComboBox = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doorsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seatsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engineCapacityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Страна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 19);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Производитель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 19);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Модель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 19);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 4;
            label5.Text = "Цена";
            // 
            // availableCheckBox
            // 
            availableCheckBox.AutoSize = true;
            availableCheckBox.Location = new Point(430, 39);
            availableCheckBox.Name = "availableCheckBox";
            availableCheckBox.RightToLeft = RightToLeft.No;
            availableCheckBox.Size = new Size(75, 19);
            availableCheckBox.TabIndex = 6;
            availableCheckBox.Text = "Наличие";
            availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(218, 37);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(100, 23);
            modelTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(324, 37);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 8;
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(6, 37);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(100, 23);
            countryComboBox.TabIndex = 9;
            // 
            // brandComboBox
            // 
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(112, 37);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(100, 23);
            brandComboBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(brandComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(countryComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(priceTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(modelTextBox);
            groupBox1.Controls.Add(availableCheckBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 68);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Основные данные";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(doorsNumericUpDown);
            groupBox2.Controls.Add(seatsNumericUpDown);
            groupBox2.Controls.Add(engineCapacityNumericUpDown);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(horsePowerTextBox);
            groupBox2.Controls.Add(transmissionComboBox);
            groupBox2.Controls.Add(engineTypeComboBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(driveComboBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(bodyComboBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 113);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Технические характеристики";
            // 
            // doorsNumericUpDown
            // 
            doorsNumericUpDown.Location = new Point(6, 81);
            doorsNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            doorsNumericUpDown.Name = "doorsNumericUpDown";
            doorsNumericUpDown.Size = new Size(115, 23);
            doorsNumericUpDown.TabIndex = 23;
            // 
            // seatsNumericUpDown
            // 
            seatsNumericUpDown.Location = new Point(127, 81);
            seatsNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            seatsNumericUpDown.Name = "seatsNumericUpDown";
            seatsNumericUpDown.Size = new Size(115, 23);
            seatsNumericUpDown.TabIndex = 22;
            // 
            // engineCapacityNumericUpDown
            // 
            engineCapacityNumericUpDown.DecimalPlaces = 1;
            engineCapacityNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            engineCapacityNumericUpDown.Location = new Point(248, 81);
            engineCapacityNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            engineCapacityNumericUpDown.Name = "engineCapacityNumericUpDown";
            engineCapacityNumericUpDown.Size = new Size(115, 23);
            engineCapacityNumericUpDown.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(369, 63);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 20;
            label12.Text = "Мощность (л.с.)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(248, 63);
            label11.Name = "label11";
            label11.Size = new Size(102, 15);
            label11.TabIndex = 19;
            label11.Text = "Объем двигателя";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(127, 63);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 18;
            label10.Text = "Кол-во мест";
            // 
            // horsePowerTextBox
            // 
            horsePowerTextBox.Location = new Point(369, 81);
            horsePowerTextBox.Name = "horsePowerTextBox";
            horsePowerTextBox.Size = new Size(115, 23);
            horsePowerTextBox.TabIndex = 17;
            horsePowerTextBox.Text = "100";
            // 
            // transmissionComboBox
            // 
            transmissionComboBox.FormattingEnabled = true;
            transmissionComboBox.Location = new Point(369, 37);
            transmissionComboBox.Name = "transmissionComboBox";
            transmissionComboBox.Size = new Size(115, 23);
            transmissionComboBox.TabIndex = 14;
            // 
            // engineTypeComboBox
            // 
            engineTypeComboBox.FormattingEnabled = true;
            engineTypeComboBox.Location = new Point(248, 37);
            engineTypeComboBox.Name = "engineTypeComboBox";
            engineTypeComboBox.Size = new Size(115, 23);
            engineTypeComboBox.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 63);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 12;
            label9.Text = "Кол-во дверей";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "Кузов";
            // 
            // driveComboBox
            // 
            driveComboBox.FormattingEnabled = true;
            driveComboBox.Location = new Point(127, 37);
            driveComboBox.Name = "driveComboBox";
            driveComboBox.Size = new Size(115, 23);
            driveComboBox.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 19);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 4;
            label8.Text = "Тип трансмиссии";
            // 
            // bodyComboBox
            // 
            bodyComboBox.FormattingEnabled = true;
            bodyComboBox.Location = new Point(6, 37);
            bodyComboBox.Name = "bodyComboBox";
            bodyComboBox.Size = new Size(115, 23);
            bodyComboBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 19);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 2;
            label7.Text = "Тип двигателя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 19);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 1;
            label6.Text = "Привод";
            // 
            // button1
            // 
            button1.Location = new Point(12, 205);
            button1.Name = "button1";
            button1.Size = new Size(507, 30);
            button1.TabIndex = 13;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 205);
            button2.Name = "button2";
            button2.Size = new Size(507, 30);
            button2.TabIndex = 14;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // AddCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 241);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "AddCar";
            Text = "Добавление автомобиля";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doorsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)seatsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)engineCapacityNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private CheckBox availableCheckBox;
        private TextBox modelTextBox;
        private TextBox priceTextBox;
        private ComboBox countryComboBox;
        private ComboBox brandComboBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox horsePowerTextBox;
        private ComboBox transmissionComboBox;
        private ComboBox engineTypeComboBox;
        private Button button1;
        private NumericUpDown doorsNumericUpDown;
        private NumericUpDown seatsNumericUpDown;
        private NumericUpDown engineCapacityNumericUpDown;
        protected internal ComboBox driveComboBox;
        protected internal ComboBox bodyComboBox;
        private Button button2;
    }
}