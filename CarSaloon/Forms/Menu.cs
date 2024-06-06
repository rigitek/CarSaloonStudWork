using CarSaloon.Cars;
using CarSaloon.Forms.Sales;

namespace CarSaloon
{
    public partial class Menu : Form
    {
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
    }
}
