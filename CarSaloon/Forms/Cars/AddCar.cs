using CarSaloon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSaloon.Forms.Cars
{
    public partial class AddCar : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public AddCar()
        {
            InitializeComponent();

            brandComboBox.DataSource = db.Brands.ToArray();
            brandComboBox.DisplayMember = "Title";
            brandComboBox.ValueMember = "Id";

            countryComboBox.DataSource = db.Countries.ToArray();
            countryComboBox.DisplayMember = "Title";
            countryComboBox.ValueMember = "Id";

            bodyComboBox.DataSource = db.Bodies.ToArray();
            bodyComboBox.DisplayMember = "Title";
            bodyComboBox.ValueMember = "Id";

            engineTypeComboBox.DataSource = db.EngineTypes.ToArray();
            engineTypeComboBox.DisplayMember = "Title";
            engineTypeComboBox.ValueMember = "Id";

            transmissionComboBox.DataSource = db.Transmissions.ToArray();
            transmissionComboBox.DisplayMember = "Title";
            transmissionComboBox.ValueMember = "Id";

            driveComboBox.DataSource = db.Drives.ToArray();
            driveComboBox.DisplayMember="Title";
            driveComboBox.ValueMember="Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TechData techData = new TechData();

            techData.Body = bodyComboBox.SelectedItem as Body;
            techData.Drive = driveComboBox.SelectedItem as Drive;
            techData.Transmission = transmissionComboBox.SelectedItem as Transmission;
            techData.EngineType = engineTypeComboBox.SelectedItem as EngineType;
            techData.EngineCapacity = (float)engineCapacityNumericUpDown.Value;
            techData.Seats = (int)seatsNumericUpDown.Value;
            techData.Doors=(int)doorsNumericUpDown.Value;
            techData.HorsePower = int.Parse(horsePowerTextBox.Text);

            db.TechData.Add(techData);
            db.SaveChanges();

            Car car = new Car();

            car.Brand=brandComboBox.SelectedItem as Brand;
            car.Country=countryComboBox.SelectedItem as Country;
            car.Model = modelTextBox.Text;
            car.Price = int.Parse(priceTextBox.Text);
            car.Available = availableCheckBox.Checked;
            car.TechData = techData;

            db.Cars.Add(car);
            db.SaveChanges();

            this.Close();

           
        }
    }
}
