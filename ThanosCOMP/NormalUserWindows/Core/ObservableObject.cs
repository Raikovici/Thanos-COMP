using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ThanosCOMP.NormalUserWindows.Core
{
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnProprietyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        }
    }
}
