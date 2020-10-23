using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleLib
{
    public class Manager
    {
        public History History { get; set; }
        public Manager()
        {
            this.History = TasksStorageHandler.GetHistoryFromDefaultFile();
        }
    }
}
