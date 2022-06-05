using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CaesarChiffre.WPF.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        /* ViewModelBase-Class
         Implements INotifyPropertyChanged for dynamic Data Binding
         Implements INotifyDataErrorInfo for Data Validation */

        // Maps list of Errors to property
        public readonly Dictionary<string, List<string>> _propertyNameToErrorsDictionary = new Dictionary<string, List<string>>();
        public bool HasErrors => _propertyNameToErrorsDictionary.Any(); // Evaluates to true if the dictionary isn't empty

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;


        public void AddError(string propertyName, string errorMessage)
        {
            // Adds an Error and, if necessary, the property itself (Key) to the dict 
            if (!_propertyNameToErrorsDictionary.ContainsKey(propertyName))
            {
                _propertyNameToErrorsDictionary.Add(propertyName, new List<string>());
            }
            _propertyNameToErrorsDictionary[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            return _propertyNameToErrorsDictionary.GetValueOrDefault(propertyName, new List<string>());
        }
    }
}
