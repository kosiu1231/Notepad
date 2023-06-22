
namespace Notepad.json.element
{
    public abstract class JsonElement
    {
        public int Id { get; set; }

        public JsonElement(int id)
        {
            this.Id = id;
        }
    }
}
