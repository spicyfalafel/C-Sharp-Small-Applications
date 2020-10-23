using MemoriseWordsLibrary;
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

namespace MemoWords
{
    public partial class MainWindow : Window
    {
        private Quiz quiz;
        private List<User> AllUsers;
        private FileManager fm;
        private User CurrUser;
        public MainWindow(User user)
        {
            InitializeComponent();
            UserName.Text += user.Login;
            fm = new FileManager();
            AllUsers = fm.GetUsersFromFile(fm.DefFileName);
            CurrUser = AllUsers.Where(u => u.Login == user.Login && u.Password == user.Password)
                .FirstOrDefault();
            quiz = new Quiz(CurrUser);
            RefreshUI();
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var add = new Add(CurrUser);
            add.Closed += Add_Closed;
            add.Show();
        }

        private void Add_Closed(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            quiz.NextWord();
            RefreshUI();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CurrentWord.Text = quiz.CurrentWord.Translated;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string ans = input.Text;
            bool correct = quiz.Guess(ans);
            string res = "";
            if (correct)
            {
                res = "Correct!";
            }
            else
            {
                res = "Wrong!";
            }
            MessageBox.Show(res);
        }

        private void RefreshUI()
        {
            string trans = quiz.CurrentWord.Translated;
            string w = quiz.CurrentWord.WordToLearn;
            CurrentWord.Text = w;

            CurrentNumberOfCard.Content = quiz.CurrentWordIndex+1 + "/"
                + quiz.user.Words.Count;
        }
        //save default
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fm.SaveUserToFile(fm.DefFileName, CurrUser);
            MessageBox.Show("Saved");
        }
    }
}
