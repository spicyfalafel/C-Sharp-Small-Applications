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
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        MyMoneyManager m;
        bool Costs;
        public Add()
        {
            InitializeComponent();
        }

        public Add(bool costs, MyMoneyManager MMM)
        {
            Costs = costs;
            m = MMM;
            InitializeComponent();
        }

        //https://stackoverflow.com/questions/1268552/how-do-i-get-a-textbox-to-only-accept-numeric-input-in-wpf
        private static readonly Regex _regex = new Regex("[^0-9]"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            string nam = name.Text;
            try
            {
                decimal mon = decimal.Parse(money.Text);
                if (Costs)
                {
                    m.SubMoney(new Costs(nam, mon, m.PickedDate));
                }
                else
                {
                    m.AddMoney(new Income(nam, mon, m.PickedDate));
                }
                Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Only numbers please! " + ex.Message, "Error while parsing", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
        }

        private void money_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!IsTextAllowed(money.Text) || money.Text.Length > 30)
            {
                money.Text = "";
            }
        }
    }
}
