using CarSaloon.Forms.Cars;
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
        CarSaloonContext db = new CarSaloonContext();
        public CarsList()
        {
            InitializeComponent();

            DBRefresh();

            dataGridView1.DataSource = db.Cars.Local.ToBindingList();

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["TechData"].Visible = false;

            dataGridView1.Columns["Brand"].HeaderText = "Производитель";
            dataGridView1.Columns["Model"].HeaderText = "Модель";
            dataGridView1.Columns["Year"].HeaderText = "Год";
            dataGridView1.Columns["Country"].HeaderText = "Страна";
            dataGridView1.Columns["Available"].HeaderText = "Наличие";
            dataGridView1.Columns["Price"].HeaderText = "Цена Руб.";
            dataGridView1.Columns["Odometer"].HeaderText = "Пробег Км.";
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

            dataGridView1.DataSource = db.Cars.Local.ToBindingList();
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
                bodyLabel.Text += car.TechData.Body;
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

            db.Cars.Load();
            dataGridView1.DataSource = db.Cars.Local.ToBindingList();
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
    }
}
