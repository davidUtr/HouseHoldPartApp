using HouseHoldPart.Model.Entities;
using HouseHoldPart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HouseHoldPart.View.AddWindow
{
    /// <summary>
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
            LoadPost();
        }

        private void LoadPost()
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            var post = dbAccess.GetPost();
            PostCB.ItemsSource = post;

        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            try
            {

                if (Name.Text == "" || Surname.Text == "" || Serial.Text == "" || Number.Text == "" || NumberPhone.Text == "" || Address.Text == "" || PostCB.ItemsSource == null)
                {
                    MessageBox.Show("Заполните все данные!");
                }
                else
                {
                    var newEmployee = new Employee
                    {
                        NameEmployee = Name.Text,
                        SurnameEmployee = Surname.Text,
                        Contact = NumberPhone.Text,
                        Address = Address.Text,
                        SerialPasportEmployee = int.Parse(Serial.Text),
                        NumberPasportEmployee = int.Parse(Number.Text),
                        IdPost = (int)PostCB.SelectedValue
                    };

                    dbAccess.AddEmployee(newEmployee);
                    db.SaveChanges();
                    MessageBox.Show("Сотрудник успешно добавлен!");
                    this.Close();


                }

            }
            catch { MessageBox.Show("Произошла ошибка! Введите все данные правильно!"); }
        }
    }
}
