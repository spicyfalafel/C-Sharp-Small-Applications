using ScheduleLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;

namespace Schedule
{
    public partial class ScheduleForm : Form
    {
        private readonly Manager Manager;
        public ScheduleForm(Manager m)
        {
            InitializeComponent();
            this.Manager = m;
            SetDatesInColumns();
            SetTasksInColumns();
        }

        private void SetTasksInColumns()
        {
            var today = DateTime.Now.Date;
            var yesterday = today.AddDays(-1);
            var tomorrow = today.AddDays(1);

            var tasksToday = Manager.History.GetNotDoneTasksWithDate(today);
            var tasksYesterday = Manager.History.GetNotDoneTasksWithDate(yesterday);
            var tasksTomorrow = Manager.History.GetNotDoneTasksWithDate(tomorrow);
            tasksToday.ToList().ForEach(el => TodayCheckedList.Items.Add(el));
            tasksYesterday.ToList().ForEach(el => YesterdayCheckedList.Items.Add(el));
            tasksTomorrow.ToList().ForEach(el => TomorrowCheckedList.Items.Add(el));
        }

        private void SetDatesInColumns()
        {
            todayLabel.Text += " (" + DateHandler.GetTodayDate() + ")";
            yesterdayLabel.Text += " (" + DateHandler.GetDateInFormatFromToday(-1) + ")";
            tomorrowLabel.Text += " (" + DateHandler.GetDateInFormatFromToday(1) + ")";
        }

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void AndHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HistoryForm(Manager).Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string loc = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/tasks.json";
            TasksStorageHandler.SaveTasksToFile(Manager.History.AllTasks, loc);
        }

        void AddTaskToListBox(PersonalTask task, ListBox listBox)
        {
            listBox.Items.Add(task);
            Manager.History.AllTasks.Add(task);
        }

        private void TodaySubmitButton_Click(object sender, EventArgs e)
        {
            PersonalTask task = new PersonalTask(todayTaskText.Text, DateTime.Now);
            AddTaskToListBox(task, TodayCheckedList);
        }
        private void YesterdaySubmit_Click(object sender, EventArgs e)
        {
            PersonalTask task = new PersonalTask(yesterdayText.Text, DateHandler.GetDateFromToday(-1));
            AddTaskToListBox(task, YesterdayCheckedList);
        }

        private void TomorrowSubmitButton_Click(object sender, EventArgs e)
        {
            PersonalTask task = new PersonalTask(tomorrowTaskText.Text, DateHandler.GetDateFromToday(1));
            AddTaskToListBox(task, TomorrowCheckedList);
        }

        private void SaveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TasksStorageHandler.SaveFileUsingDialog(Manager.History.AllTasks);
        }
        private void CheckedListWithWhiteItems3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCheckingToRemove(YesterdayCheckedList);
        }

        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.listbox.selectedindexchanged?view=netcore-3.1
        private void TodayCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCheckingToRemove(TodayCheckedList);
        }

        private void SetCheckingToRemove(ListBox list)
        {
            if (list.SelectedItem != null)
            {
                var task = list.SelectedItem.ToString();
                Manager.History.MakeDone(task);
                list.Items.Remove(list.SelectedItem);
            }
        }

        private void TomorrowCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCheckingToRemove(TomorrowCheckedList);
        }
    }
}