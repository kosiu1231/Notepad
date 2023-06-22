using Notepad.json;
using Notepad.json.element;
using Notepad.ViewModels;
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

            Note n = new Note(_Id, "New note", DateTime.Now, "Content");
            db.Db.Notes.Add(n);
            db.save();

            // Powiadom NotesListingViewModel o zmianach w kolekcji _items
            NotesListingViewModel notesListingViewModel = (App.Current.MainWindow.DataContext as NotepadViewModel).NotesListingViewModel;
            notesListingViewModel?.RefreshItems();
            notesListingViewModel.SelectedNotesListingItemViewModel = new NotesListingItemViewModel(n);
        }
    }
}
