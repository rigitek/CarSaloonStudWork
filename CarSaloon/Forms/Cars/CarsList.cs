﻿using CarSaloon.Forms.Cars;
using CarSaloon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarSaloon.Cars
{
    public partial class CarsList : Form
    {
        public CarSaloonContext db = new CarSaloonContext();
        public List<Car> Cars;
        public CarsList()
        {
            InitializeComponent();

            DBRefresh();

            dataGridView1.DataSource = db.Cars.Where(x => x.Available == true).ToList();

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["TechData"].Visible = false;

            dataGridView1.Columns["Brand"].HeaderText = "Марка";
            dataGridView1.Columns["Model"].HeaderText = "Модель";
            dataGridView1.Columns["Year"].HeaderText = "Год";
            dataGridView1.Columns["Country"].HeaderText = "Страна";
            
            dataGridView1.Columns["Price"].HeaderText = "Цена Руб.";
            dataGridView1.Columns["Odometer"].HeaderText = "Пробег Км.";
            dataGridView1.Columns["Available"].HeaderText = "Наличие";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }



        private void cleanBrandButton_Click(object sender, EventArgs e)
        {


            dataGridView1.DataSource = db.Cars.Where(x => x.Available == true).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Car car = db.Cars.Find(id);

                bodyLabel.Text = "Кузов: ";
                bodyLabel.Text += car.TechData.Body.Title;
                driveLabel.Text = "Привод: ";
                driveLabel.Text += car.TechData.Drive.Title;
                engineTypeLabel.Text = "Двигатель: ";
                engineTypeLabel.Text += car.TechData.EngineType.Title;
                transmissionLabel.Text = "Трансмиссия: ";
                transmissionLabel.Text += car.TechData.Transmission.Title;
                doorsLabel.Text = "Кол-во дверей: ";
                doorsLabel.Text += car.TechData.Doors;
                seatsLabel.Text = "Кол-во мест: ";
                seatsLabel.Text += car.TechData.Seats;
                horsePowerLabel.Text = "Мощность: ";
                horsePowerLabel.Text += car.TechData.HorsePower + " л.с.";
                engineCapacityLabel.Text = "Объем двигателя: ";
                engineCapacityLabel.Text += car.TechData.EngineCapacity + " литров";
                steeringLabel.Text = "Руль: ";
                steeringLabel.Text += car.TechData.Steering;
                if (car.TechData.ABS == true)
                {
                    ABSLabel.Text = "ABS: ";
                    ABSLabel.Text += "Есть";
                }
                else
                {
                    ABSLabel.Text = "ABS: ";
                    ABSLabel.Text += "Нет";
                }
                if (car.TechData.AC == true)
                {
                    ACLabel.Text = "Кондиционер: ";
                    ACLabel.Text += "Есть";
                }
                else
                {
                    ACLabel.Text = "Кондиционер: ";
                    ACLabel.Text += "Нет";
                }
                if (car.TechData.Multimedia == true)
                {
                    multimediaLabel.Text = "Мультимедиа: ";
                    multimediaLabel.Text += "Есть";
                }
                else
                {
                    multimediaLabel.Text = "Мультимедиа: ";
                    multimediaLabel.Text += "Нет";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddCar().ShowDialog();

            DBRefresh();

            dataGridView1.DataSource = db.Cars.Where(x => x.Available == true).ToList();
            dataGridView1.Refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Car car = db.Cars.Find(id);
                db.Cars.Remove(car);
                db.SaveChanges();

                MessageBox.Show("Автомобиль удален");

                db.Cars.Load();
                dataGridView1.DataSource = db.Cars.Local.ToBindingList();

                bodyLabel.Text = "Кузов: ";
                driveLabel.Text = "Привод: ";
                engineTypeLabel.Text = "Двигатель: ";
                transmissionLabel.Text = "Трансмиссия: ";
                doorsLabel.Text = "Кол-во дверей: ";
                seatsLabel.Text = "Кол-во мест: ";
                horsePowerLabel.Text = "Мощность: ";
                engineCapacityLabel.Text = "Объем двигателя: ";
                steeringLabel.Text = "Руль: ";
                ABSLabel.Text = "ABS: ";
                ACLabel.Text = "Кондиционер: ";
                multimediaLabel.Text = "Мультимедиа: ";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Car car = db.Cars.Find(id);
                new AddCar(car).ShowDialog();

                db.SaveChanges();

                DBRefresh();
                dataGridView1.Refresh();

                dataGridView1.DataSource = db.Cars.Local.ToBindingList();

                MessageBox.Show("Автомобиль изменен");

                this.Refresh();
            }
        }

        private void DBRefresh()
        {
            db.Cars.Load();
            db.Countries.Load();
            db.Brands.Load();
            db.TechData.Load();
            db.Transmissions.Load();
            db.Bodies.Load();
            db.Drives.Load();
            db.EngineTypes.Load();
            db.Steerings.Load();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            if (filter.ShowDialog() == DialogResult.OK)
            {
                if (filter.ABSCheckBox.Checked)
                {
                    Cars = db.Cars.Where(x => x.TechData.ABS == filter.ABSCheckBox.Checked).ToList();
                }
                else Cars = db.Cars.ToList();
                if (filter.ACCheckBox.Checked)
                {
                    Cars = Cars.Where(x => x.TechData.AC == filter.ACCheckBox.Checked).ToList();
                }
                else Cars = Cars.ToList();
                if (filter.availableCheckBox.Checked)
                {
                    Cars = Cars.Where(x => x.Available == filter.availableCheckBox.Checked).ToList();
                }
                else Cars = Cars.ToList();
                if (filter.bodyComboBox.DataSource != null)
                {
                    Cars = Cars.Where(x => x.TechData.Body.Title == filter.bodyComboBox.Text).ToList();
                }
                if (filter.brandComboBox.DataSource != null)
                {
                    Cars = Cars.Where(x => x.Brand.Title == filter.brandComboBox.Text).ToList();
                }
                if (filter.countryComboBox.DataSource != null)
                {
                    Cars = Cars.Where(x => x.Country.Title == filter.countryComboBox.Text).ToList();
                }
                if (filter.driveComboBox.DataSource != null)
                {
                    Cars = Cars.Where(x => x.TechData.Drive.Title == filter.driveComboBox.Text).ToList();
                }
                if (filter.engineCapacityFromNumericUpDown != null)
                {
                    Cars = Cars.Where(x => x.TechData.EngineCapacity >= ((float)filter.engineCapacityFromNumericUpDown.Value)).ToList();
                }
                if (filter.engineCapacityToNumericUpDown != null)
                {
                    Cars = Cars.Where(x => x.TechData.EngineCapacity <= ((float)filter.engineCapacityToNumericUpDown.Value)).ToList();
                }
                if (filter.engineTypeComboBox.DataSource != null)
                {
                    Cars = Cars.Where(x => x.TechData.EngineType.Title == filter.engineTypeComboBox.Text).ToList();
                }
                if (filter.horsePowerFromTextBox.Text != "")
                {
                    Cars = Cars.Where(x => x.TechData.HorsePower > int.Parse(filter.horsePowerFromTextBox.Text)).ToList();
                }
                if (filter.horsePowerToTextBox.Text != "")
                {
                    Cars = Cars.Where(x => x.TechData.HorsePower < int.Parse(filter.horsePowerToTextBox.Text)).ToList();
                }
                if (filter.multimediaCheckBox.Checked)
                {
                    Cars = Cars.Where(x => x.TechData.Multimedia == filter.multimediaCheckBox.Checked).ToList();
                }
                if (filter.odometerFromTextBox.Text != "")
                {
                    Cars = Cars.Where(x => x.Odometer >= int.Parse(filter.odometerFromTextBox.Text)).ToList();
                }
                if (filter.odometerToTextBox.Text != "")
                {
                    Cars = Cars.Where(x => x.Odometer <= int.Parse(filter.odometerToTextBox.Text)).ToList();
                }
                if (filter.priceFromTextBox.Text != "")
                {
                    Cars = Cars.Where(x => x.Price >= int.Parse(filter.priceFromTextBox.Text)).ToList();
                }
                if (filter.priceToTextBox.Text != "")
                {
                    Cars = Cars.Where(x => x.Price <= int.Parse(filter.priceToTextBox.Text)).ToList();
                }
                if (filter.steeringComboBox.DataSource != null)
                {
                    Cars = Cars.Where(x => x.TechData.Steering.Title == filter.steeringComboBox.Text).ToList();
                }
                if (filter.transmissionComboBox.DataSource != null)
                {
                    Cars = Cars.Where(x => x.TechData.Transmission.Title == filter.transmissionComboBox.Text).ToList();
                }
                if (filter.yearFormTextBox.Text != "")
                {
                    Cars = Cars.Where(x => x.Year >= int.Parse(filter.yearFormTextBox.Text)).ToList();
                }
                if (filter.yearToTextBox.Text != "")
                {
                    Cars = Cars.Where(x => x.Year <= int.Parse(filter.yearToTextBox.Text)).ToList();
                }

                bodyLabel.Text = "Кузов: ";
                driveLabel.Text = "Привод: ";
                engineTypeLabel.Text = "Двигатель: ";
                transmissionLabel.Text = "Трансмиссия: ";
                doorsLabel.Text = "Кол-во дверей: ";
                seatsLabel.Text = "Кол-во мест: ";
                horsePowerLabel.Text = "Мощность: ";
                engineCapacityLabel.Text = "Объем двигателя: ";
                steeringLabel.Text = "Руль: ";
                ABSLabel.Text = "ABS: ";
                ACLabel.Text = "Кондиционер: ";
                multimediaLabel.Text = "Мультимедиа: ";

                dataGridView1.DataSource = Cars;
                dataGridView1.Refresh();
            }
        }


       
    }
}