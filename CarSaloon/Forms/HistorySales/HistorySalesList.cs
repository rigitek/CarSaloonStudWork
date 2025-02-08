using CarSaloon.Cars;
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

namespace CarSaloon.Forms.HistorySales
{
    public partial class HistorySalesList : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public HistorySalesList()
        {
            InitializeComponent();

            DBRefresh();

            dataGridView1.DataSource = db.Sales.Local.ToList();

            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["Client"].HeaderText = "Клиент";
            dataGridView1.Columns["Car"].HeaderText = "Автомобиль";
            dataGridView1.Columns["Price"].HeaderText = "Цена";
            dataGridView1.Columns["Date"].HeaderText = "Дата и время";
            dataGridView1.Columns["Payment"].HeaderText = "Платеж";
            dataGridView1.Columns["Employee"].HeaderText = "Сотрудник";

            sumSales.Text = db.Sales.ToList().Sum(x => x.Price).ToString();
            amountSales.Text = db.Sales.ToList().Count.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistorySalesList_FormClosing(object sender, FormClosingEventArgs e)
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
            db.Sales.Load();
            db.Employees.Load();
        }

        private void brandComboBox_Click(object sender, EventArgs e)
        {
            brandComboBox.DataSource = db.Brands.ToList();
            brandComboBox.DisplayMember = "Title";
            brandComboBox.ValueMember = "Id";
        }

        private void clientsComboBox_Click(object sender, EventArgs e)
        {
            clientsComboBox.DataSource = db.Clients.ToList();
            clientsComboBox.DisplayMember = "Name";
            clientsComboBox.ValueMember = "Id";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            brandComboBox.DataSource = null;
            brandComboBox.Text = "Не выбрано";

            clientsComboBox.DataSource = null;
            clientsComboBox.Text = "Не выбрано";

            employeeComboBox.DataSource = null;
            employeeComboBox.Text = "Не выбрано";

            dataGridView1.DataSource = db.Sales.Local.ToBindingList();

            sumSales.Text = db.Sales.ToList().Sum(x => x.Price).ToString();
            amountSales.Text = db.Sales.ToList().Count.ToString();
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientsComboBox.DataSource == null && employeeComboBox.DataSource == null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Where(x => x.Car.Brand == brandComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Where(x => x.Car.Brand == brandComboBox.SelectedItem).ToList().Count.ToString();
            }
            else if (clientsComboBox.DataSource != null && employeeComboBox.DataSource == null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList().Count.ToString();
            }
            else if (clientsComboBox.DataSource == null && employeeComboBox.DataSource != null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList().Count.ToString();
            }
            else
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Local.Where(x => x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList().Count.ToString();
            }
        }

        private void clientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandComboBox.DataSource == null && employeeComboBox.DataSource == null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Client == clientsComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Where(x => x.Client == clientsComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Where(x => x.Client == clientsComboBox.SelectedItem).ToList().Count.ToString();
            }
            else if (brandComboBox.DataSource != null && employeeComboBox.DataSource == null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Client == clientsComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Local.Where(x => x.Client == clientsComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Local.Where(x => x.Client == clientsComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem).ToList().Count.ToString();
            }
            else if (brandComboBox.DataSource == null && employeeComboBox.DataSource != null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Client == clientsComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Local.Where(x => x.Client == clientsComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Local.Where(x => x.Client == clientsComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList().Count.ToString();
            }
            else
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Client == clientsComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Where(x => x.Client == clientsComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Where(x => x.Client == clientsComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem && x.Employee == employeeComboBox.SelectedItem).ToList().Count.ToString();
            }
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

                Sale sale = db.Sales.Find(id);
                db.Sales.Remove(sale);
                db.SaveChanges();

                MessageBox.Show("Запись о продаже удалена");

                db.Sales.Load();
                dataGridView1.DataSource = db.Sales.Local.ToList();

                brandComboBox.DataSource = null;
                brandComboBox.Text = "Не выбрано";

                clientsComboBox.DataSource = null;
                clientsComboBox.Text = "Не выбрано";

                sumSales.Text = db.Sales.ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.ToList().Count.ToString();
            }
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandComboBox.DataSource == null && clientsComboBox.DataSource == null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Employee == employeeComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Where(x => x.Employee == employeeComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Where(x => x.Employee == employeeComboBox.SelectedItem).ToList().Count.ToString();
            }
            else if (brandComboBox.DataSource != null && clientsComboBox.DataSource == null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Local.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Local.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem).ToList().Count.ToString();
            }
            else if (brandComboBox.DataSource == null && clientsComboBox.DataSource != null)
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Local.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Local.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList().Count.ToString();
            }
            else
            {
                dataGridView1.DataSource = db.Sales.Local.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList();

                sumSales.Text = db.Sales.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList().Sum(x => x.Price).ToString();
                amountSales.Text = db.Sales.Where(x => x.Employee == employeeComboBox.SelectedItem && x.Car.Brand == brandComboBox.SelectedItem && x.Client == clientsComboBox.SelectedItem).ToList().Count.ToString();
            }
        }

        private void employeeComboBox_Click(object sender, EventArgs e)
        {
            employeeComboBox.DataSource = db.Employees.ToList();
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
        }
    }
}