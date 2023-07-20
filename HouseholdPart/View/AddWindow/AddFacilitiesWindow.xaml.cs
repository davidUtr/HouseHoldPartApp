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
    /// Логика взаимодействия для AddFacilitiesWindow.xaml
    /// </summary>
    public partial class AddFacilitiesWindow : Window
    {
        public AddFacilitiesWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            if (string.IsNullOrEmpty(NameFacilitiesText.Text))
            {
                MessageBox.Show("Пожалуста, заполните название помещения!");
            }
            else
            {
                var newFacilities = new Facilities()
                {
                    NameFacilities = NameFacilitiesText.Text
                };
                dbAccess.AddFacilities(newFacilities);
                db.SaveChanges();
                MessageBox.Show("Помещение успешно добавлено!");
                this.Close();
            }
        }
    }
}
