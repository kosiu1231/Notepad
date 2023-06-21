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
        //TODO: przy setterach zaaktualizować _Note z bazy danych
        public Note Note { get; }
        public string Title { get; }
        public DateTime DateTime { get; }
        public string Content { get; }

        public ICommand ShowCommand { get; }
        public ICommand DeleteCommand { get; }

        public NotesListingItemViewModel(Note _Note)
        {
            this.Note = _Note;
            this.Title = _Note.Title;
            this.DateTime = _Note.DateTime;
            this.Content = _Note.Content;
        }
    }
}
