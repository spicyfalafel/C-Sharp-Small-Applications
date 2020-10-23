using Microsoft.Win32;
using MoneyManager;
using MoneyManagerClasses;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoneyJournal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyMoneyManager MMM;
        bool CostsSelected = true;
        public MainWindow()
        {
            MMM = MyMoneyManager.FromFile();
            InitializeComponent();
            if (MMM.MoneyLeft == 0)
            {
                SetMoney();
            }
            SetLists();
        }

        public void SetMoney()
        {
            var setMoney = new SetMoney(MMM);
            setMoney.Closed += SetMoney_Closed;
            setMoney.Topmost = true;
            setMoney.Show();
        }

        private void SetMoney_Closed(object sender, EventArgs e)
        {
            moneyleft.Text = "Money left: " + MMM.MoneyLeft;
        }

        // add new
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           
            var form = new Add(CostsSelected, MMM);
            form.Closed += Form_Closed;
            form.Show();
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            SetLists();
        }

        private void SetLists()
        {
            Costs.Items.Clear();
            Income.Items.Clear();
            foreach(var tr in MMM.ListTransactions.Where(tr => tr.Day.Date == MMM.PickedDate.Date).Where(tr => tr.IsCosts))
            {
                Costs.Items.Add(tr);
            }
            foreach (var tr in MMM.ListTransactions.Where(tr => tr.Day.Date == MMM.PickedDate.Date).Where(tr => !tr.IsCosts))
            {
                Income.Items.Add(tr);
            }
            moneyleft.Text = "Money left: " + MMM.MoneyLeft;
            TodayMoney.Text = "Today:" + MMM.GetTodayMoney() + "";
        }

        private void DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            MMM.PickedDate = (DateTime) DatePicker.SelectedDate;
            SetLists();
        }

        private void CostsTabs_GotFocus(object sender, RoutedEventArgs e)
        {
            AddButton.Content = "Add to Costs";
            CostsSelected = true;
        }

        private void TabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            AddButton.Content = "Add to Income";
            CostsSelected = false;
        }

        // save in file
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, MMM.Serialize());
            }
                
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SetMoney();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MMM.SaveInFile();
        }
    }
}
