using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PomodoroLib
{
    public static class FileStatistics
    {
        public static PomodoroStatistics GetStatisticsFromJsonFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                string fileValue = File.ReadAllText(filepath);
                return GetStatisticsFromString(fileValue);
            }
            else
            {
                return new PomodoroStatistics();
            }
        }

        public static PomodoroStatistics GetStatisticsFromString(string json)
        {
            return JsonConvert.DeserializeObject<PomodoroStatistics>(json);
        }

        public static void SaveToFile(PomodoroStatistics statistics, string loc)
        {
            using (var file = new StreamWriter(@loc, false))
            {
                foreach (var task in SerializeStatistics(statistics))
                {
                    file.Write(task);
                }
            }
        }


        public static string SerializeStatistics(PomodoroStatistics statistics)
        {
            return JsonConvert.SerializeObject(statistics);
        }
    }
}
