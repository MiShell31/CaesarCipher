using Encrypter.MVVM.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;

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

        private bool IsNumber(string wert)
        {
            Regex notNumbers = new Regex(@"[\D]+");
            if (notNumbers.IsMatch(wert)) { return false; }
            else return true;
        }

        private string _caesarKey = "3";
        public string CaesarKey
        {
           get { return _caesarKey; }
           set
            {
                _propertyNameToErrorsDictionary.Remove(nameof(CaesarKey));
                _caesarKey = value;
                
                if (!IsNumber(_caesarKey))
                {
                    AddError(nameof(CaesarKey), "Der Schlüssel darf nur eine ganze, positive Zahl sein.");
                }
                OnPropertyChanged(nameof(CaesarKey));
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
        public RelayCommand DecryptionCommand { get; set; }
        public RelayCommand SwitchCommand { get; set; }

        public EncryptionViewModel()
        {
            CaesarEncryptionModel EM = new CaesarEncryptionModel();
            EncryptionCommand = new RelayCommand(o =>
            {
                int schlüssel = Int32.Parse(CaesarKey);
                OutputText = EM.CaesarEncrypt(InputText, schlüssel);
                
            });
            DecryptionCommand = new RelayCommand(o =>
            {
                try
                {
                    int schlüssel = Int32.Parse(CaesarKey);
                    OutputText = EM.CaesarDecrypt(InputText, schlüssel);
                }
                catch
                {
                    return;
                }
                
            });

            SwitchCommand = new RelayCommand(o =>
            {
                string a = InputText;
                InputText = OutputText;
                OutputText = a;
            });
        }
    }
}
