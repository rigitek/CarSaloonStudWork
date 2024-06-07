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

namespace CarSaloon.Cars
{
    public partial class ClientsList : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public ClientsList()
        {
            InitializeComponent();

            db.Clients.Load();

            dataGridView1.DataSource = db.Clients.Local.ToBindingList();
        }

        private void ClientsList_Load(object sender, EventArgs e)
        {
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Menu menu = new Menu();
            menu.Show();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                Name = nameTextBox.Text,
                Passport = passportTextBox.Text,
                Address = adressTextBox.Text,
                Phone = phoneTextBox.Text,
                Delivery = deliveryCheckBox.Checked,
                Paymant = paymantComboBox.Text
            };

            db.Clients.Add(client);
            db.SaveChanges();
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

                Client client = db.Clients.Find(id);
                db.Clients.Remove(client);
                db.SaveChanges();

            }
        }
    }
}
