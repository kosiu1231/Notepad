using System.Drawing;

namespace Notepad.json.element
{
    public class Tag : JsonElement
    {
        public string name;
        public Color color;

        public Tag(int id, string name, Color color) : base(id)
        {
            this.name = name;
            this.color = color;
        }
    }
}
