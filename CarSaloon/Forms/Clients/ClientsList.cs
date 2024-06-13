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

            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["Name"].HeaderText = "ФИО";
            dataGridView1.Columns["Phone"].HeaderText = "Номер телефона";
            dataGridView1.Columns["Passport"].HeaderText = "Паспорт";
            dataGridView1.Columns["Address"].HeaderText = "Адрес";
            dataGridView1.Columns["Delivery"].HeaderText = "Доставка";
            dataGridView1.Columns["Paymant"].HeaderText = "Платеж";
            
            

            paymantComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientsList_FormClosing(object sender, FormClosingEventArgs e)
        {

            Menu menu = new Menu();
            menu.Show();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0) MessageBox.Show("Не заполнено ФИО", "Ошибка добавления", MessageBoxButtons.OK);
            if (passportTextBox.Text.Length == 0) MessageBox.Show("Не заполнен паспорт", "Ошибка добавления", MessageBoxButtons.OK);
            if (phoneTextBox.Text.Length == 0) MessageBox.Show("Не заполнен телефон", "Ошибка добавления", MessageBoxButtons.OK);
            if (paymantComboBox.Text.Length == 0) MessageBox.Show("Не выбран вид платежа", "Ошибка добавления", MessageBoxButtons.OK);
            if (adressTextBox.Text.Length == 0) MessageBox.Show("Не заполнен адрес", "Ошибка добавления", MessageBoxButtons.OK);

            if (nameTextBox.Text.Length > 0 &&
                passportTextBox.Text.Length > 0 &&
                phoneTextBox.Text.Length > 0 &&
                paymantComboBox.Text.Length > 0 &&
                adressTextBox.Text.Length > 0)
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

            MessageBox.Show("Новый клиент добавлен");
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

                MessageBox.Show("Клиент удален");
            }
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

                Client client = db.Clients.Find(id);

                nameTextBox.Text = client.Name;
                passportTextBox.Text = client.Passport;
                adressTextBox.Text = client.Address;
                phoneTextBox.Text = client.Phone;
                paymantComboBox.Text = client.Paymant;
                deliveryCheckBox.Checked = client.Delivery;

                deleteButton.Enabled = true;
                editButton.Enabled = true;
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            nameTextBox.Clear();
            passportTextBox.Clear();
            adressTextBox.Clear();
            phoneTextBox.Clear();
            paymantComboBox.SelectedIndex = -1;
            deliveryCheckBox.Checked = false;

            deleteButton.Enabled = false;
            editButton.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Client client = db.Clients.Find(id);

                client.Name = nameTextBox.Text;
                client.Passport = passportTextBox.Text;
                client.Address = adressTextBox.Text;
                client.Phone = phoneTextBox.Text;
                client.Paymant = paymantComboBox.Text;
                client.Delivery = deliveryCheckBox.Checked;

                db.SaveChanges();
                dataGridView1.Refresh();

                MessageBox.Show("Данные клиента обновлены");

            }
        }
    }
}
