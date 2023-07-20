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
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using System.ComponentModel;
using HouseHoldPart.View.EditWindow;
using System.Collections.ObjectModel;

namespace HouseHoldPart.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для EquipmentPage.xaml
    /// </summary>
    public partial class EquipmentPage : Page
    {
        private Suppliers selectedSupplier;
        private Facilities selectedFacilities;
        public EquipmentPage()
        {
            InitializeComponent();
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            EquipmentDG.ItemsSource = dbAccess.GetAllEquipment();
            SuppliersSearchButton.ItemsSource = dbAccess.GetSuppliers();
            FacilitiesSearchButton.ItemsSource = dbAccess.GetFacilities();

            FilterDataGrid();
        }


        private void AddScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            AddEquipmentWindow add = new AddEquipmentWindow();
            add.ShowDialog();
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            EquipmentDG.ItemsSource = dbAccess.GetAllEquipment();
            SuppliersSearchButton.ItemsSource = dbAccess.GetSuppliers();

            // Установка обновленного списка помещений
            FacilitiesSearchButton.ItemsSource = dbAccess.GetFacilities();
            FilterDataGrid();
            db.Dispose();
        }

        private void SuppliersSearchButton_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedSupplier = SuppliersSearchButton.SelectedItem as Suppliers;
            FilterDataGrid();
        }

        private void FacilitiesSearchButton_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedFacilities = FacilitiesSearchButton.SelectedItem as Facilities;
            FilterDataGrid();
        }
        private void FilterDataGrid()
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            var equipment = dbAccess.GetAllEquipment();

            // Фильтр поставщиков
            if (selectedSupplier != null && selectedSupplier.SupplierId != -1)
            {
                equipment = equipment.Where(x => x.IdSuppliers == selectedSupplier.SupplierId).ToList();
            }

            // Фильтр помещений
            if (selectedFacilities != null && selectedFacilities.FacilitiesId != -1)
            {
                equipment = equipment.Where(x => x.IdFacilities == selectedFacilities.FacilitiesId).ToList();
            }

            EquipmentDG.ItemsSource = equipment;
        }

        private void SearchDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = SearchDate.SelectedDate; // Получаем выбранную пользователем дату
            ICollectionView view = CollectionViewSource.GetDefaultView(EquipmentDG.ItemsSource); // Получаем представление коллекции
            if (selectedDate.HasValue) // Если пользователь выбрал дату
            {
                view.Filter = item =>
                {
                    Equipment equipment = item as Equipment; // Получаем текущий объект Schedule
                    return equipment.PurchaseDate == selectedDate.Value.Date; // Фильтруем записи по дате
                };
            }
            else // Если пользователь не выбрал дату
            {
                view.Filter = null; // Отображаем все занятия
            }
        }

        private void EditMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (EquipmentDG.SelectedItem != null)
            {
                // Получение данных выбранной строки
                Equipment selectedItem = (Equipment)EquipmentDG.SelectedItem;
                // Создание нового экземпляра окна редактирования
                EditEquipmentWindow editWindow = new EditEquipmentWindow(selectedItem);
                // Открытие окна
                editWindow.ShowDialog();
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                EquipmentDG.ItemsSource = dbAccess.GetAllEquipment();
                SuppliersSearchButton.ItemsSource = dbAccess.GetSuppliers();
            }
        }

        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Equipment selectedItem = (Equipment)EquipmentDG.SelectedItem;
            if (selectedItem != null && MessageBox.Show("Вы уверены что хотите удалить эту запись?", "Удаление записи", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                int EquipmentId = selectedItem.EquipmentId;
                dbAccess.RemoveEquipment(EquipmentId);
                EquipmentDG.ItemsSource = dbAccess.GetAllEquipment();
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
                    EquipmentDG.SelectedItem = row.DataContext;
                    // Присваиваем Tag выбранной строке
                    ((ContextMenu)FindResource("ItemContextMenu")).Tag = EquipmentDG.SelectedItem;
                    // Открываем контекстное меню
                    ((ContextMenu)FindResource("ItemContextMenu")).IsOpen = true;
                    e.Handled = true;
                }
            }
        }
    }
}
