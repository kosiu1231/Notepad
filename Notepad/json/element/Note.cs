using System;
using System.Collections.Generic;

namespace Notepad.json.element
{
    public class Note : JsonElement
    {
        public string title;
        public DateTime dateTime;
        public string content;
        public List<int> tagIds;

        public Note(int id, string title, DateTime dateTime, string content) : base(id)
        {
            this.title = title;
            this.dateTime = dateTime;
            this.content = content;
            tagIds = new List<int>();
        }
    }
}
