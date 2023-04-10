using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace GameRPG
{
    public static class Json_System
    {
        public static string Path = @"C:\Users\Никита\source\repos\GameRPG\Resource\Resource\";

        public static JsonSerializerOptions Options{
            get{ return new JsonSerializerOptions{WriteIndented=true};}
        }
        public static void SaveObject<T>(T _object, string path){
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate)){
                JsonSerializer.Serialize<T>(fs, _object);
            }
        }
        public static T LoadObject<T>(string path){
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate)){
                T _object = JsonSerializer.Deserialize<T>(fs);
                return _object;
            }
        }
        public static string FilePath(string name){
            return Path+ name + ".json";
        }
        public static string FilePath(string path,string name)
        {
            return path + name + ".json";
        }
    }
}