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
            dataGridView1.DataSource = db.Cars.Local.ToBindingList();

            
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

                //bodyLabel.Text = car.TechData.Body.Title.ToString();
                driveLabel.Text = "Привод: ";
                driveLabel.Text += car.TechData.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();

            dataGridView1.Refresh();
        }
    }
}
