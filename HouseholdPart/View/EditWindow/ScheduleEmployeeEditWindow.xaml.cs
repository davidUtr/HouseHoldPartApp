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
    /// Логика взаимодействия для ScheduleEmployeeEditWindow.xaml
    /// </summary>
    public partial class ScheduleEmployeeEditWindow : Window
    {
        public ScheduleEmployeeEditWindow(ScheduleEmployee selectedItem)
         : base()
        {
            InitializeComponent();
            DataContext = selectedItem;
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
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);

            if (DataContext is ScheduleEmployee schedule)
            {
                if (string.IsNullOrEmpty(schedule.EmployeeName) || !schedule.Date.HasValue || !schedule.TimeStart.HasValue || !schedule.TimeEnd.HasValue)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    dbAccess.UpdateScheduleEmployee(schedule);
                    MessageBox.Show("Данные успешно сохранены!");
                    this.Close();
                }
            }
        }


        }
}
