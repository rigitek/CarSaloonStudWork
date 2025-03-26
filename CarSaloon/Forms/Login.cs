using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarSaloon.Models;
using Microsoft.EntityFrameworkCore;

namespace CarSaloon.Forms
{
    public partial class Login : Form
    {
        CarSaloonContext db = new CarSaloonContext();

        List<Employee> employees { get; set; }
        Employee Employee = new Employee();
        public Login()
        {
            InitializeComponent();

            db.Employees.Load();

            employees = db.Employees.ToList();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length > 0) // проверяем введён ли логин     
            {
                if (passwordTextBox.Text.Length > 0) // проверяем введён ли пароль         
                {
                    // ищем в базе данных пользователя с такими данными         
                    var db_user = employees.Where(x => x.Login == loginTextBox.Text && x.Password == passwordTextBox.Text);

                    if (db_user.Count() > 0) // если такая запись существует       
                    {
                        Employee = employees.FirstOrDefault(x => x.Login == loginTextBox.Text && x.Password == passwordTextBox.Text);

                        Global.Employee = Employee;

                        Menu Menu = new Menu();
                        //закрывает уже открытое окно
                        this.Hide();
                        //открывает новое окно
                        Menu.Show();
                    }
                    else MessageBox.Show("Пользователь не найден"); // выводим ошибку 
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку 
        }
    }
}