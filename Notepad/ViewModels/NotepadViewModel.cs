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
        public ICommand AddNoteCommand { get; }

    }
}
