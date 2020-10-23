using System;
using System.Collections.Generic;
using System.Text;

namespace PomodoroLib
{
    public class PomodoroStatistics
    {
        public Dictionary<string, int> PomodorosInARow { get; set; }
        public Dictionary<string, int> PomodoroUsed { get; set; }

        public void AddNumberOfPomodorosToday(int number)
        {
            PomodoroUsed.Add(TodayToString(), number);
        }

        public PomodoroStatistics()
        {
            PomodorosInARow = new Dictionary<string, int>();
            PomodoroUsed = new Dictionary<string, int>();
        }

        public string TodayToString()
        {
            DateTime t = DateTime.Now;
            return t.Day + "-" + t.Month + "-" + t.Year;
        }

        public void AddNumberOfPomodorosInARowToday(int number)
        {
            PomodorosInARow[TodayToString()] =  number;
        }
    }
}
