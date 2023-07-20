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
    /// Логика взаимодействия для EditSuppliersWindow.xaml
    /// </summary>
    public partial class EditSuppliersWindow : Window
    {
        public EditSuppliersWindow(Suppliers selectedItem)
        {
            InitializeComponent();
            PhoneText.Mask = "+9(999) 999 99 99";
            DataContext = selectedItem;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            if (DataContext is Suppliers suppliers)
            {
                if (string.IsNullOrEmpty(suppliers.NameSupplier) || string.IsNullOrEmpty(suppliers.Contact) || string.IsNullOrEmpty(suppliers.Comments))
                {
                    MessageBox.Show("Пожалуйста, заполните все данные!");
                }    
                else
                {
                    dbAccess.UpdateSuppliers(suppliers);
                    MessageBox.Show("Данные успешно сохранены!");
                    this.Close();
                }
            }
        }
    }
}
