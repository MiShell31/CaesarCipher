using System;
using System.Globalization;
using System.Windows.Controls;

namespace Encrypter.MVVM.ValidationRules
{
    class CaesarKeyValidation : ValidationRule
    {
        public int key { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                if (((string)value).Length > 0) 
                {
                    key = int.Parse((string)value);
                }
            }
            catch (Exception e)
            {
                return new ValidationResult(false, $"Es sind nur natürliche Zahlen erlaub: {e.Message}");
            }
            return ValidationResult.ValidResult;
        }
    }
}