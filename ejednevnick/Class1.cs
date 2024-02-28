using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ejednevnick
{   
    internal class data_pro
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

    }
    
    
    
   // 
    public class Serializasial
    {   
        public string path = "C:\\Users\\Eduard\\source\\repos\\ejednevnick\\ejednevnick\\json\\file.json";
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
}