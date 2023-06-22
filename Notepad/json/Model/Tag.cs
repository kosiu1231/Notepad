using System.Drawing;

namespace Notepad.json.element
{
    public class Tag : JsonElement
    {
        public string Name;
        public Color Color;

        public Tag(int _Id, string _Name, Color _Color) : base(_Id)
        {
            this.Name = _Name;
            this.Color = _Color;
        }
    }
}
