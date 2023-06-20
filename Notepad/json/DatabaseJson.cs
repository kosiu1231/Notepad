using Notepad.json.element;
using System.Collections.Generic;

namespace Notepad.json
{
    public class DatabaseJson
    {
        public List<Note> notes { get; set; } = new List<Note>();
        public List<Tag> tags { get; set; } = new List<Tag>();
    }
}
