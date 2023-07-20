using HouseHoldPart.Model;
using HouseHoldPart.Model.Entities;
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

namespace HouseHoldPart.View.EditWindow
{
    /// <summary>
    /// Логика взаимодействия для EditEmployeeWindow.xaml
    /// </summary>
    public partial class EditEmployeeWindow : Window
    {
        public EditEmployeeWindow(Employee selectedItem)
        {
            InitializeComponent();
            DataContext = selectedItem;
            LoadPost();
        }

        private void LoadPost()
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            var post = dbAccess.GetPost();
            PostCB.ItemsSource= post;

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            try
            {
                if (DataContext is Employee employee)
                {
                    if (string.IsNullOrEmpty(employee.NameEmployee) || string.IsNullOrEmpty(employee.SurnameEmployee) || !employee.SerialPasportEmployee.HasValue || !employee.NumberPasportEmployee.HasValue || string.IsNullOrEmpty(employee.Contact) || string.IsNullOrEmpty(employee.Address))
                    {
                        MessageBox.Show("Заполните все данные!");
                    }
                    else
                    {
                        dbAccess.UpdateEmployee(employee);
                        MessageBox.Show("Данные успешно сохранены!");
                        this.Close();
                    }
                }
            } catch { MessageBox.Show("Произошла ошибка! Введите все данные правильно!"); }
        }
    }
}
