using Notepad.json;
using Notepad.json.element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Commands
{
    public class AddNoteCommand : CommandBase
    {
        public override void Execute(object? parameter)
        {
            Database db = Database.getInstance();
            int _Id = 0;
            try
            {
                _Id = db.Db.Notes.Last().Id + 1;
            }
            catch (Exception) { }

            db.Db.Notes.Add(new Note(_Id, "New note", DateTime.Now, "Content"));
            db.save();
        }
    }
}
