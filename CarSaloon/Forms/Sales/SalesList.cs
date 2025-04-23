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
        Car CarSale;
        Client ClientSale;
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

            
            clientsDataGridView.Columns["Name"].HeaderText = "ФИО";
            clientsDataGridView.Columns["Phone"].HeaderText = "Номер телефона";

            employeeComboBox.DataSource = db.Employees.ToArray();
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
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
            db.Employees.Load();
            db.Steerings.Load();
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
                CarSale = car;

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
                engineCapacityLabel.Text += car.TechData.EngineCapacity + " л.";
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
                ClientSale = client;

                nameLabel.Text = "ФИО: ";
                nameLabel.Text += client.Name;
                phoneLabel.Text = "Телефон: ";
                phoneLabel.Text += client.Phone;
                addressLabel.Text = "Адрес: ";
                addressLabel.Text += client.Address;
                passportLabel.Text = "Паспорт: ";
                passportLabel.Text += client.Passport;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientSale == null) MessageBox.Show("Не выбран клиент", "Ошибка", MessageBoxButtons.OK);
            if (CarSale == null) MessageBox.Show("Не выбран автомобиль", "Ошибка", MessageBoxButtons.OK);
            if (employeeComboBox == null) MessageBox.Show("Не выбран ответственный", "Ошибка", MessageBoxButtons.OK);

            if (ClientSale != null && CarSale!=null && employeeComboBox!=null)
            {
                Sale sale = new Sale();

                sale.Car = CarSale;
                sale.Client = ClientSale;
                sale.Price = CarSale.Price;
                sale.Date = DateTime.Now;
                sale.Payment = paymentComboBox.Text;
                sale.Employee= employeeComboBox.SelectedItem as Employee;

                db.Sales.Add(sale);
                db.SaveChanges();

                MessageBox.Show("Продажа проведена");
            }
        }
    }
}
