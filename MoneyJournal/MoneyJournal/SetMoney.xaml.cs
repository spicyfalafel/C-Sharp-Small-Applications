using MoneyManagerClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MoneyManager
{
    /// <summary>
    /// Interaction logic for SetMoney.xaml
    /// </summary>
    public partial class SetMoney : Window
    {
        public SetMoney()
        {
            InitializeComponent();
        }
        MyMoneyManager m;
        public SetMoney(MyMoneyManager m)
        {
            this.m = m;
            InitializeComponent();
        }

        //https://stackoverflow.com/questions/1268552/how-do-i-get-a-textbox-to-only-accept-numeric-input-in-wpf
        private static readonly Regex _regex = new Regex("[^0-9]"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m.MoneyLeft = decimal.Parse(money.Text);
            Close();
        }
        

        private void money_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!IsTextAllowed(money.Text))
            {
                money.Text = "";
            }
        }
    }
}
