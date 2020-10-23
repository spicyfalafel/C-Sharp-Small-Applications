using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace ScheduleLib
{
    public static class TasksStorageHandler
    {
        // https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
        // https://www.newtonsoft.com/json/help/html/SerializingJSON.htm
        public static void SaveFileUsingDialog(IList<PersonalTask> tasks)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save your tasks into json";
            saveFileDialog.ShowDialog();

            string filename = saveFileDialog.FileName;
            if (filename != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog.OpenFile();
                JsonTasksToStream(tasks, fs);
                fs.Close();
            }
        }
        private static void JsonTasksToStream(IList<PersonalTask> tasks, Stream fs)
        {
            string jsonString = TasksToJson(tasks);
            AddStringToStream(jsonString, fs);
        }
        public static string TasksToJson(IList<PersonalTask> tasks)
        {
            return JsonConvert.SerializeObject(new History(tasks));
        }
        public static void AddStringToStream(string value, Stream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            stream.Write(info, 0, info.Length);
        }
        public static void SaveTasksToFile(IList<PersonalTask> tasks, string loc)
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
            // @ : https://stackoverflow.com/questions/4879152/c-sharp-before-a-string/4879186#:~:text=It%20means%20to%20interpret%20the,where%20it%20can%20be%20used.
            
            using (var file = new StreamWriter(@loc, false))
            {
                foreach (var task in TasksToJson(tasks))
                {
                    file.Write(task);
                }
            }
        }

        public static History FromJsonToHistory(string json)
        {
            return JsonConvert.DeserializeObject<History>(json);
        }

        public static History GetHistoryFromJsonFile(string filepath)
        {   
            if (File.Exists(filepath)){
                string fileValue = File.ReadAllText(filepath);
                return FromJsonToHistory(fileValue);
            }
            else
            {
                return new History();
            }
        }
        public static History GetHistoryFromDefaultFile()
        {
            return GetHistoryFromJsonFile(Directory.GetCurrentDirectory().ToString() + "/tasks.json");
        }

    }
}