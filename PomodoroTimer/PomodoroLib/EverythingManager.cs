using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PomodoroLib
{
    public class EverythingManager
    {
        public PomodoroStatistics Stat;
        public PomodoroScheduler Scheduler;
        public EverythingManager()
        {
            Stat = FileStatistics.GetStatisticsFromJsonFile(Directory.GetCurrentDirectory() + "/statistics.json");
            Scheduler = new PomodoroScheduler(Stat);
        }
    }
}
