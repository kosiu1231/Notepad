using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class NotepadViewModel : ViewModelBase
    {
        public NotesListingViewModel NotesListingViewModel { get; }
        public SearchBarViewModel SearchBarViewModel { get; }


        public ICommand AddNoteCommand { get; }

        public NotepadViewModel()
        {
            NotesListingViewModel= new NotesListingViewModel();
            SearchBarViewModel= new SearchBarViewModel();
        }
    }
}
