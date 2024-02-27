using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ejednevnick
{
    internal class Class1
    {
        public string path = "json";
       
        public class Note
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
        }

        

    }

    static class Serializasial
    {
        public static void Serialisation<tipe>(tipe data, string path)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(path, json);

        }

        public static tipe DeSerialization<tipe>(string path)
        {
            string json = File.ReadAllText(path);// получаем  инфо из json 
            tipe Data = JsonConvert.DeserializeObject<tipe>(json); // десирилизуем 
            return Data; // возвращаем данные 
        }
    }
