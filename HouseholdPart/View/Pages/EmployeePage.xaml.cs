using HouseHoldPart.Model.Entities;
using HouseHoldPart.Model;
using HouseHoldPart.View.AddWindow;
using HouseHoldPart.View.EditWindow;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace HouseHoldPart.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();
            using (var context = new HouseholdPartEntities())
            {
                employees = new ObservableCollection<Employee>(context.Employee.ToList());
            }
            ScheduleDG.ItemsSource = employees;
        }
        public ObservableCollection<Employee> employees { get; set; } = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }


        private void SearchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchText.Text.ToLower(); // Получаем текст поиска в нижнем регистре
            ICollectionView view = CollectionViewSource.GetDefaultView(ScheduleDG.ItemsSource); // Получаем представление коллекции
            if (!string.IsNullOrEmpty(searchText)) // Если поисковая строка не пуста
            {
                view.Filter = item =>
                {
                    Employee schedule = item as Employee; // Получаем текущий объект Schedule
                    using (var context = new HouseholdPartEntities()) // Создаем новый контекст базы данных
                    {
                        // Используем LINQ-запрос для поиска сотрудника по имени или фамилии
                        var searchWords = searchText.Split(' ');
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

       

        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Employee selectedItem = (Employee)ScheduleDG.SelectedItem;
            if (selectedItem != null && MessageBox.Show("Вы уверены что хотите удалить информацию о сотруднике?", "Удаление записи", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                int ScheduleId = selectedItem.EmployeeId;
                dbAccess.RemoveEmployee(ScheduleId);
                ScheduleDG.ItemsSource = dbAccess.GetEmployee();
                db.Dispose();
                MessageBox.Show("Сотрудник успешно удален!");

            }

        }

        private void EditMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (ScheduleDG.SelectedItem != null)
            {
                // Получение данных выбранной строки
                Employee selectedItem = (Employee)ScheduleDG.SelectedItem;
                // Создание нового экземпляра окна редактирования
                EditEmployeeWindow editWindow = new EditEmployeeWindow(selectedItem);
                // Открытие окна
                editWindow.ShowDialog();
                using (var context = new HouseholdPartEntities())
                {
                    employees = new ObservableCollection<Employee>(context.Employee.ToList());
                }
                ScheduleDG.ItemsSource = employees;
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
        private void ScheduleDG_RowPreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                DataGridRow row = VisualTreeHelpers.GetParentOfType<DataGridRow>(e.OriginalSource as FrameworkElement);
                if (row != null)
                {
                    ScheduleDG.SelectedItem = row.DataContext;
                    // Присваиваем Tag выбранной строке
                    ((ContextMenu)FindResource("ItemContextMenu")).Tag = ScheduleDG.SelectedItem;
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
            AddEmployee add = new AddEmployee();
            add.ShowDialog();
            ScheduleDG.ItemsSource = dbAccess.GetEmployee();
            db.Dispose();
        }

        private void DocumentButton_Click(object sender, RoutedEventArgs e)
        {
            DocumentWindow doc = new DocumentWindow();
            doc.ShowDialog();

        }
    }
}
