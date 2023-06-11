using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

// Both EnvDTE and Systems.Window include a Window class.
// Use an alias for the class in System.Windows
using WpfWindow = System.Windows.Window;

namespace ProjectDepender
{
    public class CyclesDependenciesViewModel
    {
        public ObservableCollection<CyclesReferenceItem> CyclesItems { get; private set; }
            = new ObservableCollection<CyclesReferenceItem>();

        public ICommand CloseCommand { get; private set; }

        public CyclesDependenciesViewModel()
        {
            CloseCommand = new RelayCommand(new Action<object>(Execute_CloseCommand));
        }

        private void Execute_CloseCommand(object obj)
        {
            var win = obj as WpfWindow;
            win.Close();
        }
    }
}
