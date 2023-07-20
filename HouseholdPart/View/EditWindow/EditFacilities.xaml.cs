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
    /// Логика взаимодействия для EditFacilities.xaml
    /// </summary>
    public partial class EditFacilities : Window
    {
        public EditFacilities(Facilities selectedItem)
        {
            InitializeComponent();
            DataContext= selectedItem;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            if (DataContext is Facilities facility)
            {
                if (string.IsNullOrEmpty(facility.NameFacilities))
                {
                    MessageBox.Show("Пожалуйста, заполните все данные!");
                }
                else
                {
                    dbAccess.UpdateFacilities(facility);
                    MessageBox.Show("Данные успешно сохранены!");
                    this.Close();
                }
            }
        }
    }
}
