using Notepad.Stores;
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
        public NoteEditorViewModel NoteEditorViewModel { get; }


        public ICommand AddNoteCommand { get; }

        public NotepadViewModel(SelectedNoteStore _selectedNoteStore)
        {
            NotesListingViewModel = new NotesListingViewModel(_selectedNoteStore);
            SearchBarViewModel = new SearchBarViewModel();
            NoteEditorViewModel = new NoteEditorViewModel(_selectedNoteStore);
        }
    }
}
