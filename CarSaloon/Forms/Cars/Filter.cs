using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarSaloon.Cars;
using CarSaloon.Models;

namespace CarSaloon.Forms.Cars
{
    public partial class Filter : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public Filter()
        {
            InitializeComponent();
        }

        private void countryComboBox_Click(object sender, EventArgs e)
        {
            countryComboBox.DataSource = db.Countries.ToArray();
            countryComboBox.DisplayMember = "Title";
            countryComboBox.ValueMember = "Id";
        }

        private void brandComboBox_Click(object sender, EventArgs e)
        {
            brandComboBox.DataSource = db.Brands.ToArray();
            brandComboBox.DisplayMember = "Title";
            brandComboBox.ValueMember = "Id";
        }

        private void bodyComboBox_Click(object sender, EventArgs e)
        {
            bodyComboBox.DataSource = db.Bodies.ToArray();
            bodyComboBox.DisplayMember = "Title";
            bodyComboBox.ValueMember = "Id";
        }

        private void transmissionComboBox_Click(object sender, EventArgs e)
        {
            transmissionComboBox.DataSource = db.Transmissions.ToArray();
            transmissionComboBox.DisplayMember = "Title";
            transmissionComboBox.ValueMember = "Id";
        }

        private void driveComboBox_Click(object sender, EventArgs e)
        {
            driveComboBox.DataSource = db.Drives.ToArray();
            driveComboBox.DisplayMember = "Title";
            driveComboBox.ValueMember = "Id";
        }

        private void steeringComboBox_Click(object sender, EventArgs e)
        {
            steeringComboBox.DataSource = db.Steerings.ToArray();
            steeringComboBox.DisplayMember = "Title";
            steeringComboBox.ValueMember = "Id";
        }

        private void engineTypeComboBox_Click(object sender, EventArgs e)
        {
            engineTypeComboBox.DataSource = db.EngineTypes.ToArray();
            engineTypeComboBox.DisplayMember = "Title";
            engineTypeComboBox.ValueMember = "Id";
        }
    }
}
