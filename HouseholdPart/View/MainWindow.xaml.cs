using HouseHoldPart.Model;
using HouseHoldPart.View.Pages;
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

namespace HouseHoldPart.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nameUserText.Text = CurrentUser.Name;
            MainFrame.Content = new ScheduleEmployeePage();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            EntryWindow entry = new EntryWindow();
                entry.Show();
            this.Close();
        }

        private void ScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ScheduleEmployeePage());
        }



        private void EmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmployeePage());
        }

        private void EquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EquipmentPage());
        }

        private void SuppliersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SuppliersPage());
        }

        private void FacilitiesButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FacilitiesPage());
        }
    }
}
