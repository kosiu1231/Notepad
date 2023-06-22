using Notepad.json.element;
using Notepad.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.ViewModels
{
    public class NoteEditorViewModel : ViewModelBase
    {
        private readonly SelectedNoteStore _selectedNoteStore;

        private Note? Note => _selectedNoteStore?.Note;

        public bool HasSelectedNote => Note != null;
        public string Title
        {
            get
            {
                return Note?.Title;
            }
            set
            {
                Note.Title = value;
            }
        }

        public DateTime? DateTime
        {
            get
            {
                return Note?.DateTime;
            }
            set
            {
                if(value != null)
                {
                    Note.DateTime = (DateTime) value;
                }
            }
        }
        public string Content
        {
            get
            {
                return Note?.Content;
            }
            set
            {
                Note.Content = value;
            }
        }

        public NoteEditorViewModel(SelectedNoteStore _selectedNoteStore)
        {
            this._selectedNoteStore = _selectedNoteStore;
            _selectedNoteStore.SelectedNoteChanged += SelectedNoteStore_SelectedNoteChanged;
        }

        protected override void Dispose()
        {
            _selectedNoteStore.SelectedNoteChanged -= SelectedNoteStore_SelectedNoteChanged;
            base.Dispose();
        }

        private void SelectedNoteStore_SelectedNoteChanged()
        {
            OnPropertyChanged(nameof(HasSelectedNote));
            OnPropertyChanged(nameof(Title));
            OnPropertyChanged(nameof(DateTime));
            OnPropertyChanged(nameof(Content));
        }
    }
}
