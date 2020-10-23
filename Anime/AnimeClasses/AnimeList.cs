using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AnimeClasses 
{

    public class AnimeList 
    {
        public List<AnimeToWatch> AllAnime { get; set; }

        public List<AnimeToWatch> FavouriteAnime { get; set; }

        
        public AnimeList()
        {
            AllAnime = new List<AnimeToWatch>();
            FavouriteAnime = new List<AnimeToWatch>();
            AnimeToWatch deathnote = new AnimeToWatch("Death note", 64, "https://www.netflix.com/ru-en/title/70204970")
            {
                Year = 2008,
                MyRate = 10,
                Genres = "Magic, Drama, Psychological"
            };
            AnimeToWatch shamanKing = new AnimeToWatch("Shaman king", 64, "https://www.youtube.com/watch?v=ocfCGLsujDg")
            {
                Year = 2003,
                MyRate = 10,
                Genres = "Magic, Action"
            };
            AllAnime.Add(deathnote);
            AllAnime.Add(shamanKing);
        }

        // https://stackoverflow.com/questions/5010191/using-datacontractserializer-to-serialize-but-cant-deserialize-back
        public static string Serialize(object obj)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            using (StreamReader reader = new StreamReader(memoryStream))
            {
                DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
                serializer.WriteObject(memoryStream, obj);
                memoryStream.Position = 0;
                return reader.ReadToEnd();
            }
        }

        public static object Deserialize(string xml, Type toType)
        {
            using (Stream stream = new MemoryStream())
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(xml);
                stream.Write(data, 0, data.Length);
                stream.Position = 0;
                DataContractSerializer deserializer = new DataContractSerializer(toType);
                return deserializer.ReadObject(stream);
            }
        }

    }
}
