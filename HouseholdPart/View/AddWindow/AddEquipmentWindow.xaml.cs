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
    /// Логика взаимодействия для AddEquipmentWindow.xaml
    /// </summary>
    public partial class AddEquipmentWindow : Window
    {
        public AddEquipmentWindow()
        {
            InitializeComponent();
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
            try { 
            if (string.IsNullOrEmpty(NameEquipmentText.Text) || PurchaseDate.SelectedDate == null || string.IsNullOrEmpty(CountText.Text) || string.IsNullOrEmpty(CostText.Text) || FacilitiesCB.SelectedItem == null || SuppliersCB.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все данные!");
                    return;
            }
            else
                {
                    var db = new HouseholdPartEntities();
                    var dbAccess = new HouseHoldPartAccess(db);
                    var newEquipment = new Equipment
                    {
                        NameEquipment = NameEquipmentText.Text,
                        Count = int.Parse(CountText.Text),
                        PurchaseDate = PurchaseDate.SelectedDate,
                        Cost = decimal.Parse(CostText.Text),
                        IdFacilities = (int)FacilitiesCB.SelectedValue,
                        IdSuppliers = (int)SuppliersCB.SelectedValue

                    };
                    dbAccess.AddEquipment(newEquipment);
                    db.SaveChanges();
                    MessageBox.Show("Вы добавили новые данные!");
                    this.Close();
                }
            }
            catch { MessageBox.Show("Произошла ошибка! Проверьте данные ещё раз!"); }
        }
    }
}
