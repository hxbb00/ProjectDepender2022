using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace ProjectDepender
{
    public class CyclesReferenceItem : INotifyPropertyChanged
    {
        // Implementation of INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public string DependencyChain { get; private set; }
        // Constructor
        public CyclesReferenceItem(List<string> strings)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            DependencyChain = string.Join("->", strings);
        }

        // Utility function to fire the PropertyChanged event.
        protected virtual void NotifyPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
