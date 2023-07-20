using HouseHoldPart.Model;
using HouseHoldPart.Model.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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
using System.Xml.Linq;

namespace HouseHoldPart.View.AddWindow
{
    /// <summary>
    /// Логика взаимодействия для AddDocumentWindow.xaml
    /// </summary>
    public partial class AddDocumentWindow : Window
    {
        public AddDocumentWindow()
        {
            InitializeComponent();
            LoadEmployee();
        }

        private void LoadEmployee()
        {
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            var employee = dbAccess.GetEmployee();
            EmployeeName.ItemsSource = employee;
        }


        private void AttachDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            if (openFileDialog.ShowDialog() == true)
            { // Получаем выбранный файл и его расширение
              string filePath = openFileDialog.FileName;
                string extension = System.IO.Path.GetExtension(filePath);

                // Создаем новый экземпляр класса Document
                DocumentEmployee document = new DocumentEmployee();

                // Устанавливаем свойства для нового документа
                document.Documents = openFileDialog.SafeFileName;
                document.Path = "Documents/" + document.Documents;

                // Проверяем существование файла
                string documentsPath = "Documents/" + document.Documents;
                if (File.Exists(documentsPath))
                {
                    if (MessageBox.Show($"Файл с именем {document.Documents} уже существует в папке Documents. Хотите заменить его на выбранный файл?", "Подтверждение замены", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        // Удаляем старый файл
                        File.Delete(documentsPath);
                    }
                    else
                    {
                        return;
                    }
                }

                // Копируем выбранный файл в папку Documents
                File.Copy(filePath, documentsPath);

                // Обновляем свойство Documents у объекта DocumentEmployee
                document.Documents = System.IO.Path.GetFileName(filePath);
                // Показываем имя добавленного документа в панели
                addedDocumentPanel.Visibility = Visibility.Visible;
                addedDocumentName.Text = document.Documents;
            }
        }
   
     

                private void DeleteAddedDocumentButton_Click(object sender, RoutedEventArgs e)
             {
            // Получаем имя добавленного документа из TextBlock
            string documentName = addedDocumentName.Text;

            // Удаляем файл из папки Documents
            string documentsPath = "Documents/" + documentName;
            File.Delete(documentsPath);

            // Скрываем панель
            addedDocumentPanel.Visibility = Visibility.Collapsed;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(documentIdText.Text) || string.IsNullOrEmpty(documentNameText.Text) || EmployeeName.SelectedItem == null || string.IsNullOrEmpty(addedDocumentName.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else 
            { 
            int documentId = int.Parse(documentIdText.Text);
            int employeeId = (int)EmployeeName.SelectedValue;
            string documentName = documentNameText.Text;
            string documentsPath = addedDocumentName.Text;
            var db = new HouseholdPartEntities();
            var dbAccess = new HouseHoldPartAccess(db);
            dbAccess.AddDocuments(documentId, employeeId, documentName, documentsPath);
            MessageBox.Show("Данные успешно сохранены!");
            this.Close();
        }
        }
    }
}
