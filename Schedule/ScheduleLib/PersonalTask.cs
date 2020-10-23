using System;

namespace ScheduleLib
{
    public class PersonalTask
    {
        public DateTime TaskDate { get; set; }
        public bool IsDone { get; set; }
        public String TaskName { get; set; }

        public PersonalTask(DateTime taskDate, bool isDone, string taskName)
        {
            TaskDate = taskDate;
            IsDone = isDone;
            TaskName = taskName;
        }
        public PersonalTask() { }
        public PersonalTask(string taskName)
        {
            TaskDate = DateTime.Now;
            IsDone = false;
            TaskName = taskName;
        }
        public PersonalTask(string taskName, DateTime taskDate)
        {
            TaskDate = taskDate;
            IsDone = false;
            TaskName = taskName;
        }

        public String GetDate()
        {
            return TaskDate.Date.ToString();
        }

        public override string ToString()
        {
            return TaskName;
        }
    }
}
