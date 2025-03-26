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

namespace CarSaloon.Forms.Employees
{
    public partial class EmployeesList : Form
    {
        CarSaloonContext db = new CarSaloonContext();
        public Employee Employee { get; set; }
        public EmployeesList()
        {
            InitializeComponent();

            db.Employees.Load();
            dataGridView1.DataSource = db.Employees.Local.ToBindingList();

            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["Name"].HeaderText = "ФИО";
            dataGridView1.Columns["Post"].HeaderText = "Должность";
            dataGridView1.Columns["Login"].HeaderText = "Логин";
            dataGridView1.Columns["Password"].HeaderText = "Пароль";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeesList_FormClosing(object sender, FormClosingEventArgs e)
        {

            Menu menu = new Menu();
            menu.Show();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0) MessageBox.Show("Не заполнено ФИО", "Ошибка добавления", MessageBoxButtons.OK);
            if (postComboBox.Text.Length == 0) MessageBox.Show("Не указана должность", "Ошибка добавления", MessageBoxButtons.OK);
            if (loginTextBox.Text.Length == 0) MessageBox.Show("Не заполнен логин", "Ошибка добавления", MessageBoxButtons.OK); 
            if (passwordTextBox.Text.Length == 0) MessageBox.Show("Не заполнен пароль", "Ошибка добавления", MessageBoxButtons.OK);

            if (nameTextBox.Text.Length > 0 &&
                postComboBox.Text.Length > 0 &&
                loginTextBox.Text.Length > 0 &&
                passwordTextBox.Text.Length > 0)
            {
                Employee employee = new Employee
                {
                    Name = nameTextBox.Text,
                    Post = postComboBox.Text,
                    Login=loginTextBox.Text,
                    Password=passwordTextBox.Text
                };

                db.Employees.Add(employee);
                db.SaveChanges();

                MessageBox.Show("Новый сотрудник добавлен");
            }
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

                Employee employee= db.Employees.Find(id);
                db.Employees.Remove(employee);
                db.SaveChanges();

                MessageBox.Show("Сотрудник удален");
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

                Employee employee = db.Employees.Find(id);

                nameTextBox.Text = employee.Name;
                postComboBox.Text = employee.Post;
                loginTextBox.Text = employee.Login;
                passwordTextBox.Text = employee.Password;

                deleteButton.Enabled = true;
                editButton.Enabled = true;
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            nameTextBox.Clear();
            postComboBox.Text="Выбрать";
            loginTextBox.Clear();
            passwordTextBox.Clear();

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

                Employee employee= db.Employees.Find(id);

                employee.Name = nameTextBox.Text;
                employee.Post = postComboBox.Text;
                employee.Login = loginTextBox.Text;
                employee.Password = passwordTextBox.Text;

                db.SaveChanges();
                dataGridView1.Refresh();

                MessageBox.Show("Данные сотрудника обновлены");

            }
        }
    }
}
