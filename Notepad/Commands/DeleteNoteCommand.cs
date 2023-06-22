using Notepad.json;
using Notepad.ViewModels;
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

            // Powiadom NotesListingViewModel o zmianach w kolekcji _items
            NotesListingViewModel notesListingViewModel = (App.Current.MainWindow.DataContext as NotepadViewModel).NotesListingViewModel;
            notesListingViewModel?.RefreshItems();
        }
    }
}
