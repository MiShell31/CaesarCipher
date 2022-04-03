namespace Encrypter.MVVM.ViewModels
{
    class MainWindowViewModel : ObservableObject
    {
        /* Solely used for Content Display */
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
