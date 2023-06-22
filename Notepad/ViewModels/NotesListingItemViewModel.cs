using Notepad.Commands;
using Notepad.json.element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class NotesListingItemViewModel : ViewModelBase
    {
        //TODO: przy setterach zaaktualizować Note z bazy danych
        public Note Note { get; }

        public int Id => Note.Id;
        public string Title => Note.Title;
        public DateTime DateTime => Note.DateTime;
        public string Content => Note.Content.Length > 15 ? Note.Content.Substring(0, 20).Trim() + "..." : Note.Content;

        public ICommand DeleteCommand { get; }

        public NotesListingItemViewModel(Note _Note)
        {
            this.Note = _Note;
            DeleteCommand = new DeleteNoteCommand();
        }
    }
}
