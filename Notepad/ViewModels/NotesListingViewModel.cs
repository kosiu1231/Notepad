using Notepad.json;
using Notepad.json.element;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.ViewModels
{
    public class NotesListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<NotesListingItemViewModel> _items;

        public IEnumerable<NotesListingItemViewModel> NotesListingItemViewModels => _items;

        public NotesListingViewModel()
        {
            _items = new ObservableCollection<NotesListingItemViewModel>();
            Database.getInstance().Db.Notes.ForEach(n => _items.Add(new NotesListingItemViewModel(n)));

            // jak nie masz nic w bazie to łap placeholder :)
            /*_items.Add(new NotesListingItemViewModel(new Note(1, "tITLE", DateTime.Now, "Content")));
            _items.Add(new NotesListingItemViewModel(new Note(1, "tITLE2", DateTime.Now, "Content3")));
            _items.Add(new NotesListingItemViewModel(new Note(1, "tITLE3", DateTime.Now, "Content4")));
            _items.Add(new NotesListingItemViewModel(new Note(1, "tITLE4", DateTime.Now, "Content5")));*/
        }
    }
}
