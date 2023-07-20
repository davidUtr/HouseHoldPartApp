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
    /// Логика взаимодействия для EditEquipmentWindow.xaml
    /// </summary>
    public partial class EditEquipmentWindow : Window
    {
        public EditEquipmentWindow(Equipment selectedItem)
        {
            InitializeComponent();
            DataContext = selectedItem;
            LoadFacilities();
            LoadSuppliers();
        }

        private void LoadFacilities()
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            FacilitiesCB.ItemsSource = dbAccess.GetFacility();
        }
        private void LoadSuppliers()
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            SuppliersCB.ItemsSource = dbAccess.GetSupplier();
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // проверяем, что введенный символ - это цифра или запятая
            if (!char.IsDigit(e.Text, e.Text.Length - 1) && e.Text != ",")
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите только число");
            }
            else
            {
                // проверяем, что в текстовом поле еще нет запятых
                var textBox = sender as TextBox;
                if (textBox != null && e.Text == "," && textBox.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);

            if (DataContext is Equipment equipment)
            {
                if (string.IsNullOrEmpty(equipment.NameEquipment) || !equipment.PurchaseDate.HasValue || !equipment.Cost.HasValue || string.IsNullOrEmpty(equipment.FacilitiesName) || string.IsNullOrEmpty(equipment.SuppliersName))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля!");
                }
                else
                {
                    dbAccess.UpdateEquipment(equipment);
                    MessageBox.Show("Данные успешно сохранены!");
                    this.Close();
                }
            }
        }
    }
}
