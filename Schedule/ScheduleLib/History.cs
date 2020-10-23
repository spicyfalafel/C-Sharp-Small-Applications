using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleLib
{
    public class History
    {
        public IList<PersonalTask> AllTasks { get; set; }

        public History() => AllTasks = new List<PersonalTask>();

        public History(IList<PersonalTask> tasks) => this.AllTasks = tasks;

        public IList<PersonalTask> FilterByDate(DateTime date)
        {
            return AllTasks.Where(t => t.TaskDate.Date.Equals(date)).ToList();
        }

        public IList<PersonalTask> FilterNotDone(IList<PersonalTask> tasks)
        {
            return tasks.Where(t => t.IsDone == false).ToList();
        }

        public IList<PersonalTask> GetNotDoneTasksWithDate(DateTime date)
        {
            return FilterNotDone(FilterByDate(date));
        }

        public void MakeDone(string taskName)
        {
            AllTasks.First(el => el.TaskName.Equals(taskName)).IsDone = true;
        }
    }
}
