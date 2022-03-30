using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter.MVVM.Models
{
    class EncryptionModel
    {
        //private string InputText { get; set; }
        //private string OutputText { get; set; }

        public string CaesarEncrypt(string inputText, int key) 
        {
            if(inputText == null) { return inputText; }
            string encryptedText = null;
            for (int i = 0; i < inputText.Length; i++)
            {
                encryptedText += (char)((inputText[i] + key) % 256);
            }
            return encryptedText;
        }
    }
}
