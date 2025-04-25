namespace CarSaloon.Forms.Cars
{
    partial class Filter
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
            odometerFromTextBox = new TextBox();
            filterButton = new Button();
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            label5 = new Label();
            yearFormTextBox = new TextBox();
            label17 = new Label();
            yearToTextBox = new TextBox();
            groupBox4 = new GroupBox();
            label16 = new Label();
            priceFromTextBox = new TextBox();
            label15 = new Label();
            priceToTextBox = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            label14 = new Label();
            odometerToTextBox = new TextBox();
            label1 = new Label();
            brandComboBox = new ComboBox();
            label2 = new Label();
            countryComboBox = new ComboBox();
            availableCheckBox = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox7 = new GroupBox();
            engineCapacityToNumericUpDown = new NumericUpDown();
            label11 = new Label();
            label19 = new Label();
            engineCapacityFromNumericUpDown = new NumericUpDown();
            groupBox6 = new GroupBox();
            label18 = new Label();
            horsePowerToTextBox = new TextBox();
            label12 = new Label();
            horsePowerFromTextBox = new TextBox();
            steeringComboBox = new ComboBox();
            multimediaCheckBox = new CheckBox();
            ACCheckBox = new CheckBox();
            ABSCheckBox = new CheckBox();
            label13 = new Label();
            transmissionComboBox = new ComboBox();
            engineTypeComboBox = new ComboBox();
            label4 = new Label();
            driveComboBox = new ComboBox();
            label8 = new Label();
            bodyComboBox = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)engineCapacityToNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engineCapacityFromNumericUpDown).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // odometerFromTextBox
            // 
            odometerFromTextBox.Location = new Point(33, 16);
            odometerFromTextBox.Name = "odometerFromTextBox";
            odometerFromTextBox.Size = new Size(80, 23);
            odometerFromTextBox.TabIndex = 16;
            // 
            // filterButton
            // 
            filterButton.DialogResult = DialogResult.OK;
            filterButton.Font = new Font("Segoe UI", 12F);
            filterButton.Location = new Point(150, 333);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(260, 49);
            filterButton.TabIndex = 18;
            filterButton.Text = "Фильтровать";
            filterButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(brandComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(countryComboBox);
            groupBox1.Controls.Add(availableCheckBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(132, 370);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Основные данные";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(yearFormTextBox);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(yearToTextBox);
            groupBox5.Location = new Point(6, 269);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(120, 75);
            groupBox5.TabIndex = 25;
            groupBox5.TabStop = false;
            groupBox5.Text = "Год выпуска";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 21;
            label5.Text = "От";
            // 
            // yearFormTextBox
            // 
            yearFormTextBox.Location = new Point(33, 16);
            yearFormTextBox.Name = "yearFormTextBox";
            yearFormTextBox.Size = new Size(80, 23);
            yearFormTextBox.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 48);
            label17.Name = "label17";
            label17.Size = new Size(22, 15);
            label17.TabIndex = 22;
            label17.Text = "До";
            // 
            // yearToTextBox
            // 
            yearToTextBox.Location = new Point(33, 45);
            yearToTextBox.Name = "yearToTextBox";
            yearToTextBox.Size = new Size(80, 23);
            yearToTextBox.TabIndex = 20;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(priceFromTextBox);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(priceToTextBox);
            groupBox4.Location = new Point(6, 188);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(120, 75);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Цена";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 19);
            label16.Name = "label16";
            label16.Size = new Size(21, 15);
            label16.TabIndex = 21;
            label16.Text = "От";
            // 
            // priceFromTextBox
            // 
            priceFromTextBox.Location = new Point(33, 16);
            priceFromTextBox.Name = "priceFromTextBox";
            priceFromTextBox.Size = new Size(80, 23);
            priceFromTextBox.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 48);
            label15.Name = "label15";
            label15.Size = new Size(22, 15);
            label15.TabIndex = 22;
            label15.Text = "До";
            // 
            // priceToTextBox
            // 
            priceToTextBox.Location = new Point(33, 45);
            priceToTextBox.Name = "priceToTextBox";
            priceToTextBox.Size = new Size(81, 23);
            priceToTextBox.TabIndex = 20;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(odometerFromTextBox);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(odometerToTextBox);
            groupBox3.Location = new Point(6, 107);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(120, 75);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Пробег";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 17;
            label3.Text = "От";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 48);
            label14.Name = "label14";
            label14.Size = new Size(22, 15);
            label14.TabIndex = 18;
            label14.Text = "До";
            // 
            // odometerToTextBox
            // 
            odometerToTextBox.Location = new Point(33, 45);
            odometerToTextBox.Name = "odometerToTextBox";
            odometerToTextBox.Size = new Size(80, 23);
            odometerToTextBox.TabIndex = 19;
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
            // brandComboBox
            // 
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(6, 81);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(120, 23);
            brandComboBox.TabIndex = 10;
            brandComboBox.Click += brandComboBox_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Производитель";
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(6, 37);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(120, 23);
            countryComboBox.TabIndex = 9;
            countryComboBox.Click += countryComboBox_Click;
            // 
            // availableCheckBox
            // 
            availableCheckBox.AutoSize = true;
            availableCheckBox.Checked = true;
            availableCheckBox.CheckState = CheckState.Checked;
            availableCheckBox.Location = new Point(32, 347);
            availableCheckBox.Name = "availableCheckBox";
            availableCheckBox.RightToLeft = RightToLeft.No;
            availableCheckBox.Size = new Size(75, 19);
            availableCheckBox.TabIndex = 6;
            availableCheckBox.Text = "Наличие";
            availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(steeringComboBox);
            groupBox2.Controls.Add(multimediaCheckBox);
            groupBox2.Controls.Add(ACCheckBox);
            groupBox2.Controls.Add(ABSCheckBox);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(transmissionComboBox);
            groupBox2.Controls.Add(engineTypeComboBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(driveComboBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(bodyComboBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(150, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 315);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Технические характеристики";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(engineCapacityToNumericUpDown);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(label19);
            groupBox7.Controls.Add(engineCapacityFromNumericUpDown);
            groupBox7.Location = new Point(135, 103);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(120, 75);
            groupBox7.TabIndex = 31;
            groupBox7.TabStop = false;
            groupBox7.Text = "Объем двигателя";
            // 
            // engineCapacityToNumericUpDown
            // 
            engineCapacityToNumericUpDown.DecimalPlaces = 1;
            engineCapacityToNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            engineCapacityToNumericUpDown.Location = new Point(33, 46);
            engineCapacityToNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            engineCapacityToNumericUpDown.Name = "engineCapacityToNumericUpDown";
            engineCapacityToNumericUpDown.Size = new Size(80, 23);
            engineCapacityToNumericUpDown.TabIndex = 23;
            engineCapacityToNumericUpDown.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 48);
            label11.Name = "label11";
            label11.Size = new Size(22, 15);
            label11.TabIndex = 22;
            label11.Text = "До";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 19);
            label19.Name = "label19";
            label19.Size = new Size(21, 15);
            label19.TabIndex = 21;
            label19.Text = "От";
            // 
            // engineCapacityFromNumericUpDown
            // 
            engineCapacityFromNumericUpDown.DecimalPlaces = 1;
            engineCapacityFromNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            engineCapacityFromNumericUpDown.Location = new Point(33, 17);
            engineCapacityFromNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            engineCapacityFromNumericUpDown.Name = "engineCapacityFromNumericUpDown";
            engineCapacityFromNumericUpDown.Size = new Size(80, 23);
            engineCapacityFromNumericUpDown.TabIndex = 21;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label18);
            groupBox6.Controls.Add(horsePowerToTextBox);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(horsePowerFromTextBox);
            groupBox6.Location = new Point(135, 22);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(120, 75);
            groupBox6.TabIndex = 30;
            groupBox6.TabStop = false;
            groupBox6.Text = "Мощность";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 48);
            label18.Name = "label18";
            label18.Size = new Size(22, 15);
            label18.TabIndex = 20;
            label18.Text = "До";
            // 
            // horsePowerToTextBox
            // 
            horsePowerToTextBox.Location = new Point(33, 44);
            horsePowerToTextBox.Name = "horsePowerToTextBox";
            horsePowerToTextBox.Size = new Size(80, 23);
            horsePowerToTextBox.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 19);
            label12.Name = "label12";
            label12.Size = new Size(21, 15);
            label12.TabIndex = 18;
            label12.Text = "От";
            // 
            // horsePowerFromTextBox
            // 
            horsePowerFromTextBox.Location = new Point(33, 15);
            horsePowerFromTextBox.Name = "horsePowerFromTextBox";
            horsePowerFromTextBox.Size = new Size(80, 23);
            horsePowerFromTextBox.TabIndex = 17;
            // 
            // steeringComboBox
            // 
            steeringComboBox.FormattingEnabled = true;
            steeringComboBox.Location = new Point(6, 169);
            steeringComboBox.Name = "steeringComboBox";
            steeringComboBox.Size = new Size(120, 23);
            steeringComboBox.TabIndex = 29;
            steeringComboBox.Click += steeringComboBox_Click;
            // 
            // multimediaCheckBox
            // 
            multimediaCheckBox.AutoSize = true;
            multimediaCheckBox.Location = new Point(6, 292);
            multimediaCheckBox.Name = "multimediaCheckBox";
            multimediaCheckBox.Size = new Size(102, 19);
            multimediaCheckBox.TabIndex = 28;
            multimediaCheckBox.Text = "Мультимедиа";
            multimediaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ACCheckBox
            // 
            ACCheckBox.AutoSize = true;
            ACCheckBox.Location = new Point(6, 267);
            ACCheckBox.Name = "ACCheckBox";
            ACCheckBox.Size = new Size(101, 19);
            ACCheckBox.TabIndex = 27;
            ACCheckBox.Text = "Кондиционер";
            ACCheckBox.UseVisualStyleBackColor = true;
            // 
            // ABSCheckBox
            // 
            ABSCheckBox.AutoSize = true;
            ABSCheckBox.Location = new Point(6, 242);
            ABSCheckBox.Name = "ABSCheckBox";
            ABSCheckBox.Size = new Size(47, 19);
            ABSCheckBox.TabIndex = 26;
            ABSCheckBox.Text = "ABS";
            ABSCheckBox.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 151);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 24;
            label13.Text = "Руль";
            // 
            // transmissionComboBox
            // 
            transmissionComboBox.FormattingEnabled = true;
            transmissionComboBox.Location = new Point(6, 81);
            transmissionComboBox.Name = "transmissionComboBox";
            transmissionComboBox.Size = new Size(120, 23);
            transmissionComboBox.TabIndex = 14;
            transmissionComboBox.Click += transmissionComboBox_Click;
            // 
            // engineTypeComboBox
            // 
            engineTypeComboBox.FormattingEnabled = true;
            engineTypeComboBox.Location = new Point(6, 213);
            engineTypeComboBox.Name = "engineTypeComboBox";
            engineTypeComboBox.Size = new Size(120, 23);
            engineTypeComboBox.TabIndex = 13;
            engineTypeComboBox.Click += engineTypeComboBox_Click;
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
            driveComboBox.Location = new Point(6, 125);
            driveComboBox.Name = "driveComboBox";
            driveComboBox.Size = new Size(120, 23);
            driveComboBox.TabIndex = 10;
            driveComboBox.Click += driveComboBox_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 63);
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
            bodyComboBox.Size = new Size(120, 23);
            bodyComboBox.TabIndex = 9;
            bodyComboBox.Click += bodyComboBox_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 195);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 2;
            label7.Text = "Тип двигателя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 107);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 1;
            label6.Text = "Привод";
            // 
            // Filter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 391);
            Controls.Add(filterButton);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Filter";
            Text = "Filter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)engineCapacityToNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)engineCapacityFromNumericUpDown).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label13;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label14;
        private Label label3;
        private GroupBox groupBox3;
        private Label label15;
        private Label label16;
        private GroupBox groupBox5;
        private Label label5;
        private Label label17;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private Label label18;
        private Label label12;
        private GroupBox groupBox7;
        private Label label11;
        private Label label19;
        public TextBox odometerFromTextBox;
        public ComboBox brandComboBox;
        public ComboBox countryComboBox;
        public TextBox priceFromTextBox;
        public CheckBox availableCheckBox;
        public ComboBox steeringComboBox;
        public CheckBox multimediaCheckBox;
        public CheckBox ACCheckBox;
        public CheckBox ABSCheckBox;
        public NumericUpDown engineCapacityFromNumericUpDown;
        public TextBox horsePowerFromTextBox;
        public ComboBox transmissionComboBox;
        public ComboBox engineTypeComboBox;
        public ComboBox driveComboBox;
        public ComboBox bodyComboBox;
        public TextBox odometerToTextBox;
        public TextBox priceToTextBox;
        public TextBox yearFormTextBox;
        public TextBox yearToTextBox;
        public TextBox horsePowerToTextBox;
        public NumericUpDown engineCapacityToNumericUpDown;
        public Button filterButton;
    }
}