﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SelHoz.Service
{
    public class Helper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
