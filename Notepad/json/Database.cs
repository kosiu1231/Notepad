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
        private string filePath { get; }
        private string json { get; set; }
        protected DatabaseJson db { get; }

        public Database(string filePath)
        {
            this.filePath = filePath;
            if (!File.Exists(filePath))
            {
                db = new DatabaseJson();
                save();
                return;
            }

            json = File.ReadAllText(filePath);
            db = JsonConvert.DeserializeObject<DatabaseJson>(json);
        }

        public void save()
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, db);
            }
        }
    }
}