using Notepad.json.element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Stores
{
    public class SelectedNoteStore
    {
        private Note? _selectedNote;
        
        public Note? Note {
            get
            {
                return _selectedNote;
            }
            set
            {
                _selectedNote = value;
                SelectedNoteChanged?.Invoke();
            }
        }

        public event Action SelectedNoteChanged;
    }
}
