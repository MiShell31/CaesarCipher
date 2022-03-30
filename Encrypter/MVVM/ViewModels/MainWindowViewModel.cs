using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter.MVVM.ViewModels
{
    class MainWindowViewModel : ObservableObject
    {
        private object _currentView { get; set; }
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            } 
        }
        public EncryptionViewModel EncryptionVM;
        public MainWindowViewModel()
        {
            EncryptionVM = new EncryptionViewModel();
            CurrentView = EncryptionVM;
        }
    }
}
