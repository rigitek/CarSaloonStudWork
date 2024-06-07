using CarSaloon.Cars;
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
    }
}
