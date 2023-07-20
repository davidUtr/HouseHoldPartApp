﻿using HouseHoldPart.Model.Entities;
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
    /// Логика взаимодействия для FacilitiesPage.xaml
    /// </summary>
    public partial class FacilitiesPage : Page
    {
        public FacilitiesPage()
        {
            InitializeComponent();
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            FacilitiesDG.ItemsSource = dbAccess.GetFacility();
        }

        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Facilities selectedItem = (Facilities)FacilitiesDG.SelectedItem;
            if (selectedItem != null && MessageBox.Show("Вы уверены что хотите удалить данные?", "Удаление записи", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                int FacilitiesId = selectedItem.FacilitiesId;
                dbAccess.RemoveFacilities(FacilitiesId);
                FacilitiesDG.ItemsSource = dbAccess.GetFacility();
                db.Dispose();
                MessageBox.Show("Данные успешно удалены!");

            }
        }

        private void EditMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            if (FacilitiesDG.SelectedItem != null)
            {
                // Получение данных выбранной строки
                Facilities selectedItem = (Facilities)FacilitiesDG.SelectedItem;
                // Создание нового экземпляра окна редактирования
                EditFacilities editWindow = new EditFacilities(selectedItem);
                // Открытие окна
                editWindow.ShowDialog();
                FacilitiesDG.ItemsSource = dbAccess.GetFacility();
                db.Dispose();
            }
        }

        private void AddFacilities_Click(object sender, RoutedEventArgs e)
        {

            AddFacilitiesWindow add = new AddFacilitiesWindow();
            add.ShowDialog();
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            FacilitiesDG.ItemsSource = dbAccess.GetFacility();

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
                    FacilitiesDG.SelectedItem = row.DataContext;
                    // Присваиваем Tag выбранной строке
                    ((ContextMenu)FindResource("ItemContextMenu")).Tag = FacilitiesDG.SelectedItem;
                    // Открываем контекстное меню
                    ((ContextMenu)FindResource("ItemContextMenu")).IsOpen = true;
                    e.Handled = true;
                }
            }
        }
    }
}
