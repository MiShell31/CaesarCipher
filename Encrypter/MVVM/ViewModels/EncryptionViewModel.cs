using Encrypter.MVVM.Models;

namespace Encrypter.MVVM.ViewModels
{
    class EncryptionViewModel : ObservableObject
    {
        private string _inputText { get; set; }
        public string InputText
        {
            get { return _inputText; }
            set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }
        private int _caesarKey = 3;
        public int CaesarKey
        {
            get { return _caesarKey; }
            set
            {
                _caesarKey = value;
                OnPropertyChanged();
            }
        }

        private string _outputText { get; set; }
        public string OutputText
        {
            get { return _outputText; }
            set
            {
                _outputText = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand EncryptionCommand { get; set; }

        public EncryptionViewModel()
        {
            EncryptionModel EM = new EncryptionModel();
            EncryptionCommand = new RelayCommand(o =>
            {
                OutputText = EM.CaesarEncrypt(InputText, CaesarKey);
            });
        }
    }
}
