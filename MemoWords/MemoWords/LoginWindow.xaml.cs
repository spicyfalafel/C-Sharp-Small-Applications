using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MemoriseWordsLibrary;

namespace MemoWords
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            fm = new FileManager();
        }
        FileManager fm;
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            User user = GetFromFields();
            if (fm.DefFileExists() && fm.DefFileContainsUser(user))
            {
                new MainWindow(user).Show();

                this.Close(); 
            }else
            {
                MessageBox.Show("No such login and password", 
                    "Errrrrror", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EnterToMain(User user)
        {
            List<User> users = new List<User>();
            users.Add(user);
            fm.SaveUsersToFile(fm.DefFileName, users);
            new MainWindow(user).Show();
            this.Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            User user = GetFromFields();
            FileManager fm = new FileManager();
            if (fm.DefFileContainsUser(user))
            {
                MessageBox.Show("Already registered",
                   "Errrrrror", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(!fm.DefFileExists())
            {
                EnterToMain(user);
            }else // register him and append to file
            {
                fm.SaveUserToFile(fm.DefFileName, user);
                new MainWindow(user).Show();
                this.Close();
            }
        }

        private User GetFromFields()
        {
            string loginstr = login.Text;
            string pass = password.Password;
            User user = new User(loginstr, pass);
            return user;
        }
    }
}
