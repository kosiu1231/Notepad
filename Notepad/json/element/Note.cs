using System;
using System.Collections.Generic;

namespace Notepad.json.element
{
    public class Note : JsonElement
    {
        public string Title;
        public DateTime DateTime;
        public string Content;
        public List<int> TagIds;

        public Note(int _Id, string _Title, DateTime _DateTime, string _Content) : base(_Id)
        {
            this.Title = _Title;
            this.DateTime = _DateTime;
            this.Content = _Content;
            TagIds = new List<int>();
        }
    }
}
