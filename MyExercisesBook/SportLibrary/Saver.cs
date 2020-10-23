using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SportLibrary
{

    // serialize to json and deserialize from json
    public class Saver
    {
        public BookOfSport GetBookFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                return GetBookString(File.ReadAllText(FilePath));
            }
            else
            {
                return new BookOfSport();
            }
        }
        public BookOfSport GetBookString(string json)
        {
            return JsonConvert.DeserializeObject<BookOfSport>(json);
        }
        public void SaveToFile(BookOfSport book, string path)
        {
            var file = new StreamWriter(path, false);
            foreach (var ex in Serialize(book))
            {
                file.Write(ex);
            }
            file.Close();
        }


        //https://ngunha02.wordpress.com/2015/02/15/readingwriting-data-fromto-json-format/
        public void writeDataToFile(string fileName, BookOfSport book)
        {
            try
            {
                using (FileStream fs = File.Open(fileName + ".json", FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, book);
                }
            }
            catch (Exception e)
            {
                
            }
        }
        public string Serialize(BookOfSport book)
        {
            return JsonConvert.SerializeObject(book);
        }
    }
}