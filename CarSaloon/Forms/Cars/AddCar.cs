using CarSaloon.Cars;
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
        public Car carUpdate;
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
            driveComboBox.DisplayMember = "Title";
            driveComboBox.ValueMember = "Id";

            steeringComboBox.DataSource = db.Steerings.ToArray();
            steeringComboBox.DisplayMember = "Title";
            steeringComboBox.ValueMember = "Id";

            button1.Visible = true;
            button2.Visible = false;
        }

        public AddCar(Car car)
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
            driveComboBox.DisplayMember = "Title";
            driveComboBox.ValueMember = "Id";

            steeringComboBox.DataSource = db.Steerings.ToArray();
            steeringComboBox.DisplayMember = "Title";
            steeringComboBox.ValueMember = "Id";

            brandComboBox.SelectedValue = car.Brand.Id;
            countryComboBox.SelectedValue = car.Country.Id;
            modelTextBox.Text = car.Model;
            priceTextBox.Text = car.Price.ToString();
            availableCheckBox.Checked = car.Available;
            yearTextBox.Text = car.Year.ToString();
            odometerTextBox.Text = car.Odometer.ToString();
            VINTextBox.Text = car.VIN;

            bodyComboBox.SelectedValue = car.TechData.Body.Id;
            driveComboBox.SelectedValue = car.TechData.Drive.Id;
            transmissionComboBox.SelectedValue = car.TechData.Transmission.Id;
            engineTypeComboBox.SelectedValue = car.TechData.EngineType.Id;
            engineCapacityNumericUpDown.Value = (decimal)car.TechData.EngineCapacity;
            seatsNumericUpDown.Value = car.TechData.Seats;
            doorsNumericUpDown.Value = car.TechData.Doors;
            horsePowerTextBox.Text = car.TechData.HorsePower.ToString();
            ACCheckBox.Checked = car.TechData.AC;
            ABSCheckBox.Checked = car.TechData.ABS;
            multimediaCheckBox.Checked = car.TechData.Multimedia;
            steeringComboBox.SelectedValue = car.TechData.Steering.Id;

            button1.Visible = false;
            button2.Visible=true;

            carUpdate = car;
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
            techData.Doors = (int)doorsNumericUpDown.Value;
            techData.HorsePower = int.Parse(horsePowerTextBox.Text);
            techData.AC = ACCheckBox.Checked;
            techData.ABS = ABSCheckBox.Checked;
            techData.Multimedia = multimediaCheckBox.Checked;
            techData.Steering = steeringComboBox.SelectedItem as Steering;

            db.TechData.Add(techData);
            db.SaveChanges();

            Car car = new Car();

            car.Brand = brandComboBox.SelectedItem as Brand;
            car.Country = countryComboBox.SelectedItem as Country;
            car.Model = modelTextBox.Text;
            car.Price = int.Parse(priceTextBox.Text);
            car.Available = availableCheckBox.Checked;
            car.Year = int.Parse(yearTextBox.Text);
            car.Odometer = int.Parse(odometerTextBox.Text);
            car.VIN = VINTextBox.Text;

            car.TechData = techData;

            db.Cars.Add(car);
            db.SaveChanges();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TechData techData = db.TechData.Find(carUpdate.TechData.Id);

            techData.Body = bodyComboBox.SelectedItem as Body;
            techData.Drive = driveComboBox.SelectedItem as Drive;
            techData.Transmission = transmissionComboBox.SelectedItem as Transmission;
            techData.EngineType = engineTypeComboBox.SelectedItem as EngineType;
            techData.EngineCapacity = (float)engineCapacityNumericUpDown.Value;
            techData.Seats = (int)seatsNumericUpDown.Value;
            techData.Doors = (int)doorsNumericUpDown.Value;
            techData.HorsePower = int.Parse(horsePowerTextBox.Text);
            techData.AC = ACCheckBox.Checked;
            techData.ABS = ABSCheckBox.Checked;
            techData.Multimedia = multimediaCheckBox.Checked;
            techData.Steering = steeringComboBox.SelectedItem as Steering;

            db.TechData.Update(techData);
            db.SaveChanges();

            Car car = db.Cars.Find(carUpdate.Id);

            car.Brand = brandComboBox.SelectedItem as Brand;
            car.Country = countryComboBox.SelectedItem as Country;
            car.Model = modelTextBox.Text;
            car.Price = int.Parse(priceTextBox.Text);
            car.Available = availableCheckBox.Checked;
            car.Year = int.Parse(yearTextBox.Text);
            car.Odometer = int.Parse(odometerTextBox.Text);
            car.VIN = VINTextBox.Text;

            car.TechData = techData;

            db.Cars.Update(car);
            db.SaveChanges();

            this.Close();
        }
    }
}
