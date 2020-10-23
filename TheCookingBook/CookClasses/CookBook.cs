using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CookClasses
{
    public class CookBook
    {
        public List<Recipe> recipes;
        public CookBook()
        {
            recipes = new List<Recipe>();
        }

        public static CookBook GetFromJson()
        {
            try { 
                string file = File.ReadAllText("save.json");
                return (CookBook) JsonConvert.DeserializeObject<CookBook>(file);
            }catch(Exception e)
            {
                return null;
            }
        }

        public void ToFile(string file)
        {
            string filename = "save.json";
            if (File.Exists(filename)) File.Delete(filename);
            File.WriteAllText(filename, file);
        }

        public void ToJson()
        {
            string serializedJson = JsonConvert.SerializeObject(this);
            ToFile(serializedJson);
        }

    }
}
