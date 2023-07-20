using HouseHoldPart.Model;
using HouseHoldPart.Model.Entities;
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
    /// Логика взаимодействия для ScheduleEmployee.xaml
    /// </summary>
    public partial class ScheduleEmployeePage : Page
    {
        public ScheduleEmployeePage()
        {
            InitializeComponent();
            using (var context = new HouseholdPartEntities())
            {
                scheduleTable = new ObservableCollection<ScheduleEmployee>(context.ScheduleEmployee.ToList());
            }
            ScheduleDG.ItemsSource= scheduleTable;
        }
        public ObservableCollection<ScheduleEmployee> scheduleTable { get; set; } = new ObservableCollection<ScheduleEmployee>();
        public ObservableCollection<ScheduleEmployee> ScheduleTable { get { return scheduleTable; } }



        private void SearchDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = SearchDate.SelectedDate; // Получаем выбранную пользователем дату
            ICollectionView view = CollectionViewSource.GetDefaultView(ScheduleDG.ItemsSource); // Получаем представление коллекции
            if (selectedDate.HasValue) // Если пользователь выбрал дату
            {
                view.Filter = item =>
                {
                    ScheduleEmployee schedule = item as ScheduleEmployee; // Получаем текущий объект Schedule
                    return schedule.Date == selectedDate.Value.Date; // Фильтруем записи по дате
                };
            }
            else // Если пользователь не выбрал дату
            {
                view.Filter = null; // Отображаем все занятия
            }
        }

        private void SearchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchText.Text.ToLower(); // Получаем текст поиска в нижнем регистре
            ICollectionView view = CollectionViewSource.GetDefaultView(ScheduleDG.ItemsSource); // Получаем представление коллекции
            if (!string.IsNullOrEmpty(searchText)) // Если поисковая строка не пуста
            {
                view.Filter = item =>
                {
                    ScheduleEmployee schedule = item as ScheduleEmployee; // Получаем текущий объект Schedule
                    using (var context = new HouseholdPartEntities()) // Создаем новый контекст базы данных
                    {
                        // Используем LINQ-запрос для поиска сотрудника по имени или фамилии
                        var searchWords = searchText.Split(' ');
                        var employee = context.Employee.FirstOrDefault(g => searchWords.All(w => g.NameEmployee.ToLower().Contains(w) || g.SurnameEmployee.ToLower().Contains(w)));
                        return schedule.ScheduleId == employee?.EmployeeId; // Возвращаем true, если ID сотрудника соответствует ID сотрудника в расписании
                    }
                };
            }
            else // Если поисковая строка пуста
            {
                view.Filter = null; // Отображаем все занятия
            }
        }

        private void CopyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранную строку
            ScheduleEmployee selectedItem = (ScheduleEmployee)((ContextMenu)FindResource("ItemContextMenu")).Tag;

            // Получаем значение ячейки столбца "Ф.И.О сотрудника"
            string employeeName = selectedItem.EmployeeName;

            // Копируем значение в буфер обмена
            Clipboard.SetText(employeeName);
        }

        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ScheduleEmployee selectedItem = (ScheduleEmployee)ScheduleDG.SelectedItem;
            if (selectedItem != null && MessageBox.Show("Вы уверены что хотите удалить эту запись?", "Удаление записи", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                var db = new HouseholdPartEntities();
                var dbAccess = new HouseHoldPartAccess(db);
                int ScheduleId = selectedItem.ScheduleId;
                dbAccess.RemoveScheduleEmployee(ScheduleId);
                ScheduleDG.ItemsSource = dbAccess.GetScheduleEmployee();
                db.Dispose();
                MessageBox.Show("Расписание успешно удалено!");

            }

        }

        private void EditMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (ScheduleDG.SelectedItem != null)
            {
                // Получение данных выбранной строки
                ScheduleEmployee selectedItem = (ScheduleEmployee)ScheduleDG.SelectedItem;
                // Создание нового экземпляра окна редактирования
                ScheduleEmployeeEditWindow editWindow = new ScheduleEmployeeEditWindow(selectedItem);
                // Открытие окна
                editWindow.ShowDialog();
                using (var context = new HouseholdPartEntities())
                {
                    scheduleTable = new ObservableCollection<ScheduleEmployee>(context.ScheduleEmployee.ToList());
                }
                ScheduleDG.ItemsSource = scheduleTable;
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
            AddScheduleEmployeeWindow add = new AddScheduleEmployeeWindow();
            add.ShowDialog();
            ScheduleDG.ItemsSource = dbAccess.GetScheduleEmployee();
            db.Dispose();
        }
    }
}
