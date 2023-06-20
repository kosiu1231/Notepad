
namespace Notepad.json.element
{
    public abstract class JsonElement
    {
        int Id { get; set; }

        public JsonElement(int id)
        {
            this.Id = id;
        }
    }
}
