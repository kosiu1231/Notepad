using Notepad.Stores;
using Notepad.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedNoteStore _selectedNoteStore = new SelectedNoteStore();

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.DataContext = new NotepadViewModel(_selectedNoteStore);
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
