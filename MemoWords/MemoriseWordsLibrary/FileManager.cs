using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Resources;
using System.Text;

namespace MemoriseWordsLibrary
{ 
    public class FileManager
    {
        public  string DefFileName = "words.json";
        public List<User> GetUsersFromFile(string filename)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            if (!File.Exists(filename))
            {
                List<User> list = new List<User>();
                SaveUsersToFile(DefFileName, list);
            }
            return jsSerializer.Deserialize<List<User>>(File.ReadAllText(filename));
        }
        public void SaveUsersToFile(string filename, List<User> users)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string jsonString = jsSerializer.Serialize(users);
            File.WriteAllText(filename, jsonString);
        }

        public void SaveUserToFile(string filename, User user)
        {
            List<User> users = GetUsersFromFile(filename);
            User userToRemove = null;
            foreach(var u in users)
            {
                if (u.Equals(user))
                    {
                    userToRemove = u;
                }
            }
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
            }
            users.Add(user);
            SaveUsersToFile(filename, users);
        }
        public bool DefFileContainsUser(User user)
        {
            return GetUsersFromFile(DefFileName).Contains(user);
        }
        public bool DefFileExists()
        {
            return File.Exists(DefFileName);
        }
    }
}
