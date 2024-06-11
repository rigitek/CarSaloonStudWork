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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarSaloon.Cars
{
    public partial class CarsList : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public CarsList()
        {
            InitializeComponent();

            db.Cars.Load();
            db.Countries.Load();
            db.Brands.Load();
            db.TechData.Load();
            db.Transmissions.Load();
            db.Bodies.Load();
            db.Drives.Load();
            db.EngineTypes.Load();

            dataGridView1.DataSource = db.Cars.Local.ToBindingList();

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["TechData"].Visible = false;

            dataGridView1.Columns["Model"].HeaderText = "Модель";
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

        private void brandComboBox_Click(object sender, EventArgs e)
        {

            brandComboBox.DataSource = db.Brands.ToList();
            brandComboBox.DisplayMember = "Title";
            brandComboBox.ValueMember = "Id";

        }

        private void countryComboBox_Click(object sender, EventArgs e)
        {
            countryComboBox.DataSource = db.Countries.ToList();
            countryComboBox.DisplayMember = "Title";
            countryComboBox.ValueMember = "Id";
        }

        private void cleanCountryButton_Click(object sender, EventArgs e)
        {
            countryComboBox.DataSource = null;
            countryComboBox.Text = "Не выбрано";
        }

        private void cleanBrandButton_Click(object sender, EventArgs e)
        {
            brandComboBox.DataSource = null;
            brandComboBox.Text = "Не выбрано";
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
                engineCapacityLabel.Text += car.TechData.EngineCapacity+" литров";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();

            addCar.Show();
            
                dataGridView1.Refresh();


            this.Hide();
            
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
            }
        }

        private void FormRefresh()
        {
            this.Refresh();
        }
    }
}
