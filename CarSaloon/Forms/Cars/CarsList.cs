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

namespace CarSaloon.Cars
{
    public partial class CarsList : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public CarsList()
        {
            InitializeComponent();

            db.Cars.Load();
            //dataGridView1.DataSource = db.Cars.Local.ToBindingList();




        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void CarsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();

        }

        private void brandComboBox_Click(object sender, EventArgs e)
        {

            brandComboBox.DataSource = db.Brands.Local.ToList();
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
    }
}
