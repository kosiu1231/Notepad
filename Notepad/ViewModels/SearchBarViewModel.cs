using Notepad.Commands;
using Notepad.json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad.ViewModels
{
    public class SearchBarViewModel : ViewModelBase
    {

        public string _Search;
        public string Search
        {
            get
            {
                return _Search;
            }
            set
            {
                _Search = value;
                NotesListingViewModel notesListingViewModel = (App.Current.MainWindow.DataContext as NotepadViewModel).NotesListingViewModel;
                List<NotesListingItemViewModel> filtered = new List<NotesListingItemViewModel>();
                Database.getInstance().Db.Notes.FindAll(
                    n => n.Title.ToLower().Contains(Search.ToLower())
                        || n.Content.ToLower().Contains(Search.ToLower())
                ).ForEach(n => filtered.Add(new NotesListingItemViewModel(n)));
                notesListingViewModel?.FilterItems(filtered);
            }
        }


        public ICommand AddNoteCommand { get; }

        public SearchBarViewModel()
        {
            AddNoteCommand = new AddNoteCommand();
        }
    }
}
