using HouseHoldPart.Model;
using HouseHoldPart.Model.Entities;
using HouseHoldPart.View.AddWindow;
using HouseHoldPart.View.EditWindow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
    /// Логика взаимодействия для DocumentWindow.xaml
    /// </summary>
    public partial class DocumentWindow : Window
    {
        public DocumentWindow()
        {
            InitializeComponent();
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            ListDoc.ItemsSource = dbAccess.GetDocuments();
        }

        private void OpenDocBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedDocument = ListDoc.SelectedItem as DocumentEmployee;
                if (selectedDocument != null)
                {
                    var imagePath = AppDomain.CurrentDomain.BaseDirectory + "Documents\\" + selectedDocument.Documents;
                    Process.Start(imagePath);
                }
            }
            catch { MessageBox.Show("Произошла ошибка! Попробуйте обратиться к администратору"); }
   
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
        private void ScheduleDG_RowPreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                ListViewItem row = VisualTreeHelpers.GetParentOfType<ListViewItem>(e.OriginalSource as FrameworkElement);
                if (row != null)
                {
                    ListDoc.SelectedItem = row.DataContext;
                    // Присваиваем Tag выбранной строке
                    ((ContextMenu)FindResource("ItemContextMenu")).Tag = ListDoc.SelectedItem;
                    // Открываем контекстное меню
                    ((ContextMenu)FindResource("ItemContextMenu")).IsOpen = true;
                    e.Handled = true;
                }
            }

        }
        private void SearchButton_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchButton = SearchButton.Text.ToLower(); // Получаем текст поиска в нижнем регистре
            ICollectionView view = CollectionViewSource.GetDefaultView(ListDoc.ItemsSource); // Получаем представление коллекции
            if (!string.IsNullOrEmpty(searchButton)) // Если поисковая строка не пуста
            {
                view.Filter = item =>
                {
                    DocumentEmployee schedule = item as DocumentEmployee; // Получаем текущий объект Schedule
                    using (var context = new HouseholdPartEntities()) // Создаем новый контекст базы данных
                    {
                        // Используем LINQ-запрос для поиска сотрудника по имени или фамилии
                        var searchWords = searchButton.Split(' ');
                        var employee = context.Employee.FirstOrDefault(g => searchWords.All(w => g.NameEmployee.ToLower().Contains(w) || g.SurnameEmployee.ToLower().Contains(w)));
                        return schedule.EmployeeId == employee?.EmployeeId; // Возвращаем true, если ID сотрудника соответствует ID сотрудника в расписании
                    }
                };
            }
            else // Если поисковая строка пуста
            {
                view.Filter = null; // Отображаем все занятия
            }
        }

        private void EditMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (ListDoc.SelectedItem != null)
            {
                DocumentEmployee selectedItem = (DocumentEmployee)ListDoc.SelectedItem;
                EditDocumentWindow edit = new EditDocumentWindow(selectedItem);
                edit.ShowDialog();
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                ListDoc.ItemsSource = dbAccess.GetDocuments();

            }
          

        }

        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DocumentEmployee selectedItem = (DocumentEmployee)ListDoc.SelectedItem;
            if (selectedItem != null && MessageBox.Show("Вы уверены что хотите удалить документ?", "Удаление документа", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                int DocumentId = selectedItem.DocumentId;
                dbAccess.RemoveDocument(DocumentId);
                ListDoc.ItemsSource = dbAccess.GetDocuments();
                db.Dispose();
                MessageBox.Show("Документ успешно удален!");

            }
        }

        private void DocAddButton_Click(object sender, RoutedEventArgs e)
        {
            AddDocumentWindow add = new AddDocumentWindow();
            add.ShowDialog();
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            ListDoc.ItemsSource = dbAccess.GetDocuments();
        }
    }
    }

