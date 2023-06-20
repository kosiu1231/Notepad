using Notepad.json.element;
using System.Collections.Generic;

namespace Notepad.json
{
    public class DatabaseJson
    {
        public List<Note> Notes { get; set; } = new List<Note>();
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
