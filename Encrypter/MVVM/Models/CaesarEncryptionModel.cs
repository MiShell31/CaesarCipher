using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter.MVVM.Models
{
    class CaesarEncryptionModel
    {
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

        public string CaesarDecrypt(string inputText, int key)
        {
            if(inputText == null) { return inputText; }
            string decryptedText = null;
            key = 256 - key; 
            for(int i = 0; i < inputText.Length; i++)
            {
                decryptedText += (char)((inputText[i] + key) % 256);
            }
            return decryptedText;
        }
    }
}
