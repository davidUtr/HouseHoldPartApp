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
    /// Логика взаимодействия для AddScheduleEmployeeWindow.xaml
    /// </summary>
    public partial class AddScheduleEmployeeWindow : Window
    {
        public AddScheduleEmployeeWindow()
        {
            InitializeComponent();
            LoadEmployee();
        }

        private void LoadEmployee()
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            var employee = dbAccess.GetEmployee();
            EmployeeName.ItemsSource = employee;
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (Date.SelectedDate == null || TimeText.Text == "" || TimeEndText.Text == "" || EmployeeName.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста заполните все поля");
                return;
            }

            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);

            // Create new schedule object using inputted data
            var newSchedule = new ScheduleEmployee
            {
                Date = Date.SelectedDate.Value,
                TimeStart = TimeSpan.Parse(TimeText.Text),
                TimeEnd = TimeSpan.Parse(TimeEndText.Text),
                IdEmployee = (int)EmployeeName.SelectedValue
            };

            // Add new schedule to database
            dbAccess.AddScheduleEmployee(newSchedule);
            db.SaveChanges();

            MessageBox.Show("Новое расписание успешно добавлено!");
            this.Close();
        }
    }
    
}
