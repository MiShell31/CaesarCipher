using CaesarChiffre.WPF.Commands;
using CaesarChiffre.WPF.Models;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace CaesarChiffre.WPF.ViewModels
{
    public class ChiffreViewModel : ViewModelBase
    {
        private bool _modus { get; set; } = false;
        public bool Modus
        {
            get { return _modus; }
            set
            {
                _modus = value;
                OnPropertyChanged(nameof(Modus));
                CipherCommand?.Execute(this);
            }
        }
        private string _inputText { get; set; }
        public string InputText
        {
            /* Bound to TextBox for user text input */

            get { return _inputText; }
            set
            {
                _inputText = value;
                OnPropertyChanged(nameof(_inputText));
                CipherCommand?.Execute(this);
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
                CipherCommand?.Execute(this);
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
                OnPropertyChanged(nameof(OutputText));
            }
        }


        public ICommand CipherCommand { get; set; }

        public ChiffreViewModel(CaesarChiffreModel caesarChiffreModel)
        {
            InputText = "Gib hier deinen Text ein...";

            CipherCommand = new CipherCommand(this, caesarChiffreModel);
            CipherCommand.Execute(this);
        }
    }
}
