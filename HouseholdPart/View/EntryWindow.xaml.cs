using HouseHoldPart.Model;
using HouseHoldPart.Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

namespace HouseHoldPart.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class EntryWindow : Window
    {
        public EntryWindow()
        {
            InitializeComponent();
        }


        private void PasswordCheck_Checked(object sender, RoutedEventArgs e)
        {
            TextPasswordInput.Visibility = Visibility.Visible;
            PasswordInput.Visibility = Visibility.Hidden;
            TextPasswordInput.Text = PasswordInput.Password;
        }

        private void PasswordCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            TextPasswordInput.Visibility = Visibility.Hidden;
            PasswordInput.Visibility = Visibility.Visible;
            PasswordInput.Password = TextPasswordInput.Text;
        }

        private void PasswordInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            TextPasswordInput.Text = PasswordInput.Password;
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            using (var context = new HouseholdPartEntities())
            {
                var user = context.User.Where(x => x.Login == LoginText.Text && x.Password == TextPasswordInput.Text).FirstOrDefault();
                if (user != null)
                {
                    // код сохранения логина и пароля
                    // ...
                    CurrentUser.Name = user.FullNameUser;
                    MessageBox.Show("Вы успешно авторизовались!");
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else { MessageBox.Show("Пользователь с такими данными не найден! Проверьте введённые вами данные на правильность!"); }

            }
        }
        
    


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string filePath = "savedlogin.txt";
            if (File.Exists(filePath))
            {
                // читаем сохраненные значения
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 2)
                {
                    // загружаем значения в поля логина и пароля
                    LoginText.Text = lines[0];
                    PasswordInput.Password = lines[1];

                    // устанавливаем галочку "Запомнить пароль"
                    SavePass.IsChecked = true;
                }
            }
        
    }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SupportWindow support = new SupportWindow();
            support.ShowDialog();
            
        }
    }
}
