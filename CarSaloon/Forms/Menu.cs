using CarSaloon.Cars;
using CarSaloon.Forms;
using CarSaloon.Forms.Employees;
using CarSaloon.Forms.HistorySales;
using CarSaloon.Forms.Sales;
using CarSaloon.Models;

namespace CarSaloon
{
    public partial class Menu : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public Menu()
        {
            InitializeComponent();

            
        }

        public void carsButton_Click(object sender, EventArgs e)
        {
            CarsList carsList = new CarsList();
            carsList.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            ClientsList clientsList = new ClientsList();
            clientsList.Show();
            this.Hide();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            SalesList salesList = new SalesList();
            salesList.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void historySalesButton_Click(object sender, EventArgs e)
        {
            HistorySalesList historySalesList = new HistorySalesList();
            historySalesList.Show();
            this.Hide();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            EmployeesList employeesList = new EmployeesList();
            employeesList.Show();
            this.Hide();
        }
    }
}
