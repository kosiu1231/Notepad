using Newtonsoft.Json;
using Notepad.json.element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
using System.Windows.Input;

namespace Notepad.json
{
    public class Database
    {
        private static Database instance;

        public static Database getInstance()
        {
            if(instance == null)
            {
                instance = new Database();
            }
            return instance;
        }


        private string FilePath { get; }
        private string Json { get; set; }
        public DatabaseJson Db { get; }

        private Database()
        {
            string FilePath = "./db.json";
            if (!File.Exists(FilePath))
            {
                Db = new DatabaseJson();
                save();
                return;
            }

            Json = File.ReadAllText(FilePath);
            Db = JsonConvert.DeserializeObject<DatabaseJson>(Json);
        }

        public void save()
        {
            using (StreamWriter file = File.CreateText(FilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Db);
            }
        }
    }
}