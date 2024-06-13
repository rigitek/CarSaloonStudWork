using CarSaloon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSaloon.Forms.Sales
{
    public partial class SalesList : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public SalesList()
        {
            InitializeComponent();

            DBRefresh();

            carsDataGridView.DataSource = db.Cars.Local.Where(x => x.Available == true).ToList();

            carsDataGridView.Columns["Id"].Visible = false;
            carsDataGridView.Columns["TechData"].Visible = false;
            carsDataGridView.Columns["Available"].Visible = false;

            carsDataGridView.Columns["Country"].HeaderText = "Страна";
            carsDataGridView.Columns["Model"].HeaderText = "Модель";
            carsDataGridView.Columns["Price"].HeaderText = "Цена";
            carsDataGridView.Columns["Brand"].HeaderText = "Производитель";

            clientsDataGridView.DataSource = db.Clients.Local.ToList();

            clientsDataGridView.Columns["Id"].Visible = false;
            clientsDataGridView.Columns["Passport"].Visible = false;
            clientsDataGridView.Columns["Address"].Visible = false;
            clientsDataGridView.Columns["Delivery"].Visible = false;
            clientsDataGridView.Columns["Paymant"].Visible = false;

            clientsDataGridView.Columns["Phone"].HeaderText = "Номер телефона";
            clientsDataGridView.Columns["Name"].HeaderText = "ФИО";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

        }

        private void DBRefresh()
        {
            db.Cars.Load();
            db.Clients.Load();
            db.Countries.Load();
            db.Brands.Load();
            db.TechData.Load();
            db.Transmissions.Load();
            db.Bodies.Load();
            db.Drives.Load();
            db.EngineTypes.Load();
        }

        private void carsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (carsDataGridView.SelectedRows.Count > 0)
            {
                int index = carsDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(carsDataGridView[0, index].Value.ToString(), out id);
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
            }
        }

        private void clientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count > 0)
            {
                int index = clientsDataGridView.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(clientsDataGridView[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Client client = db.Clients.Find(id);

                addressLabel.Text = "Адрес: ";
                addressLabel.Text += client.Address;
                passportLabel.Text = "Паспорт: ";
                passportLabel.Text += client.Passport;
                deliveryLabel.Text = "Доставка: ";
                if (client.Delivery) deliveryLabel.Text += "Да";
                paymantLabel.Text = "Платеж: ";
                paymantLabel.Text += client.Paymant;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
