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
    /// Логика взаимодействия для AddSuppliersWindow.xaml
    /// </summary>
    public partial class AddSuppliersWindow : Window
    {
        public AddSuppliersWindow()
        {
            InitializeComponent();
            PhoneText.Mask = "+9(999) 999 99 99";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            if (string.IsNullOrEmpty(NameSupplierText.Text) || string.IsNullOrEmpty(PhoneText.Text) || string.IsNullOrEmpty(Comments.Text)) {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
            else
            {
                var newSuppliers = new Suppliers()
                {
                    NameSupplier = NameSupplierText.Text,
                    Contact = PhoneText.Text,
                    Comments= Comments.Text
                };
                dbAccess.AddSuppliers(newSuppliers);
                MessageBox.Show("Поставщик успешно добавлен!");
                this.Close();
            }
        }
    }
}
