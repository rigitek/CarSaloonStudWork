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
            // dataGridView1.Columns["Client"].ValueType = Client.Name;
            dataGridView1.Columns["Car"].HeaderText = "Автомобиль";
            dataGridView1.Columns["Price"].HeaderText = "Цена";
            dataGridView1.Columns["Date"].HeaderText = "Дата и время";
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
        }

        private void brandComboBox_Click(object sender, EventArgs e)
        {
            brandComboBox.DataSource = db.Brands.ToList();
            brandComboBox.DisplayMember = "Title";
            brandComboBox.ValueMember = "Id";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fromDateTimePicker.Text = null;
            toDateTimePicker.Text = null;

            brandComboBox.DataSource = null;
            brandComboBox.Text = "Не выбрано";

            clientsComboBox.DataSource = null;
            clientsComboBox.Text = "Не выбрано";

            dataGridView1.DataSource = db.Cars.Local.ToBindingList();
        }

        private void clientsComboBox_Click(object sender, EventArgs e)
        {

        }
    }
}
