using MemoriseWordsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;


namespace MemoWords
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        private User user;

        public Add(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        public Add()
        {
            InitializeComponent();
        }
        
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string word = Word.Text;
            string translate = Translation.Text;
            var w = new Word(word, translate);
            user.AddWord(w);
            Close();
        }
    }
}
