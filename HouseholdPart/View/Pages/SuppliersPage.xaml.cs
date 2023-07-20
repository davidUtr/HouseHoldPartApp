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
using System.Windows.Navigation;
using System.Windows.Shapes;
using HouseHoldPart.View.AddWindow;
using HouseHoldPart.View.EditWindow;
using System.Collections.ObjectModel;

namespace HouseHoldPart.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для SuppliersPage.xaml
    /// </summary>
    public partial class SuppliersPage : Page
    {
        public SuppliersPage()
        {
            InitializeComponent();
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            SuppliersDG.ItemsSource = dbAccess.GetSupplier();
        }

        private void EditMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (SuppliersDG.SelectedItem != null)
            {
                // Получение данных выбранной строки
                Suppliers selectedItem = (Suppliers)SuppliersDG.SelectedItem;
                // Создание нового экземпляра окна редактирования
                EditSuppliersWindow editWindow = new EditSuppliersWindow(selectedItem);
                // Открытие окна
                editWindow.ShowDialog();
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                SuppliersDG.ItemsSource = dbAccess.GetSupplier();
                db.Dispose();
            }
        }

        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Suppliers selectedItem = (Suppliers)SuppliersDG.SelectedItem;
            if (selectedItem != null && MessageBox.Show("Вы уверены что хотите удалить данные?", "Удаление записи", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                int FacilitiesId = selectedItem.SupplierId;
                dbAccess.RemoveSuppliers(FacilitiesId);
                SuppliersDG.ItemsSource = dbAccess.GetSupplier();
                db.Dispose();
                MessageBox.Show("Данные успешно удалены!");

            }
        }
        public static class VisualTreeHelpers
        {
            public static T GetParentOfType<T>(DependencyObject element) where T : DependencyObject
            {
                DependencyObject parent = VisualTreeHelper.GetParent(element);

                if (parent == null)
                    return null;

                T parentOfType = parent as T;

                if (parentOfType != null)
                    return parentOfType;

                return GetParentOfType<T>(parent);
            }
        }
        private void DataGridRow_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                DataGridRow row = VisualTreeHelpers.GetParentOfType<DataGridRow>(e.OriginalSource as FrameworkElement);
                if (row != null)
                {
                    SuppliersDG.SelectedItem = row.DataContext;
                    // Присваиваем Tag выбранной строке
                    ((ContextMenu)FindResource("ItemContextMenu")).Tag = SuppliersDG.SelectedItem;
                    // Открываем контекстное меню
                    ((ContextMenu)FindResource("ItemContextMenu")).IsOpen = true;
                    e.Handled = true;
                }
            }
            }

        private void AddScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            AddSuppliersWindow add = new AddSuppliersWindow();
            add.ShowDialog();
            SuppliersDG.ItemsSource = dbAccess.GetSupplier();
            db.Dispose();
        }
    }
}
