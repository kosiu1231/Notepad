using Notepad.json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Commands
{
    internal class DeleteNoteCommand : CommandBase
    {

        public override void Execute(object? parameter)
        {
            Database db = Database.getInstance();
            db.Db.Notes.RemoveAll(n => n.Id.Equals(parameter));
            db.save();
        }
    }
}
