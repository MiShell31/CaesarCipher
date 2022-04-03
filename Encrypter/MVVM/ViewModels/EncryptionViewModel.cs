using Encrypter.MVVM.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace Encrypter.MVVM.ViewModels
{
    class EncryptionViewModel : ObservableObject
    {
        private string _inputText { get; set; }
        public string InputText
        {
            /* Bound to TextBox for user text input */

            get { return _inputText; }
            set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }

        private bool IsNumber(string wert)
        {
            //Data Validation: Checks if the Input consists of digits only and returns true if that's the case
            Regex notNumbers = new Regex(@"[\D]+");
            if (notNumbers.IsMatch(wert)) { return false; }
            else { return true; }
        }

        private string _caesarKey = "3";
        public string CaesarKey
        {
            /* Bound to TextBox for Input key (initialized with 3) */
            get { return _caesarKey; }
            set
            { 
                _propertyNameToErrorsDictionary.Remove(nameof(CaesarKey)); //Removes any Errors regarding the property from Dictionary
                _caesarKey = value;

                if (!IsNumber(_caesarKey))
                {
                    /* Data Validation: Adds Error if the value consists of non-digits or if the field is empty. */
                    AddError(nameof(CaesarKey), "Der Schlüssel darf nur eine ganze, positive Zahl sein.");
                }
                else if (_caesarKey.Equals("")) { AddError(nameof(CaesarKey), "Bitte gib einen Schlüssel ein."); }
                OnPropertyChanged(nameof(CaesarKey));
            }
        }

        private string _outputText { get; set; }
        public string OutputText
        {
            /* Bound to TextBox that displays the output text (readonly) */
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
            
            EncryptionCommand = new RelayCommand(o =>
            {
                /* Bound to Encryption Button */

                try
                {
                    int schlüssel = Int32.Parse(CaesarKey); //parse value
                    OutputText = CaesarEncryptionModel.CaesarEncrypt(InputText, schlüssel);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Bitte überprüfe deine Eingaben: " + e.Message);
                }


            });
            DecryptionCommand = new RelayCommand(o =>
            {
                /* Bound to Decryption Button */
                try
                {
                    int schlüssel = Int32.Parse(CaesarKey); //parse value
                    OutputText = CaesarEncryptionModel.CaesarDecrypt(InputText, schlüssel);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Bitte überprüfe deine Eingaben: " + e.Message);
                }
            });

            SwitchCommand = new RelayCommand(o =>
            {
                /* Bound to switch button 
                 Switches the values of input and output text */
                string a = InputText;
                InputText = OutputText;
                OutputText = a;
            });
        }
    }
}
