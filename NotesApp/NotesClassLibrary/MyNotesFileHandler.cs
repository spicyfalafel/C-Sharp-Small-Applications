using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace NotesClassLibrary
{
    public static class MyNotesFileHandler
    {
        public static string DEFAULT_PATH = Directory.GetCurrentDirectory() + "/notes.xml";
        //https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer.deserialize?view=netcore-3.1
        public static List<Note> GetFromFileWithPath(string path)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Note>));
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            using (TextReader reader = new StreamReader(fs))
            {
                var res = (List<Note>)x.Deserialize(reader);
                return res;
            }
        }
        public static List<Note> GetFromFileDefault()
        {
            if (File.Exists(DEFAULT_PATH))
            {
                return GetFromFileWithPath(DEFAULT_PATH);
            }
            else
            {
                return new List<Note>();
            }
            
        }

        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/how-to-write-object-data-to-an-xml-file

        public static void SerializeToXmlDefault(List<Note> notes)
        {
            SerializeToXmlWithPath(notes, DEFAULT_PATH);
        }
        public static void SerializeToXmlWithPath(List<Note> notes, string path)
        {
            XmlSerializer x = new XmlSerializer(notes.GetType());
            var stream = File.Create(path);
            x.Serialize(stream, notes);
            stream.Close();
        }
    }
}
