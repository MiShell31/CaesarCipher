using System;

namespace Encrypter.MVVM.Models
{
    class CaesarEncryptionModel
    {
        //Handles the caesar chiffre encryption "logic"
        public static string CaesarEncrypt(string inputText, int key)
        {
            /* Encrypts the inputText with caesar chiffre.
            The input parameter key defines the shift distance.
            Returns the encrypted Text. */

            if (inputText == null) { return inputText; }
            key = Math.Abs(key); //Get absolute value in case the key is negative
            string encryptedText = null;
            for (int i = 0; i < inputText.Length; i++)
            {
                //Adds the encrypted character of the input string to the output string
                encryptedText += (char)((inputText[i] + key) % 256);
            }
            return encryptedText;
        }

        public static string CaesarDecrypt(string inputText, int key)
        {
            /* Decrypts the inputText with caesar chiffre.
            The input parameter key defines the shift distance.
            Returns the decrypted Text. */
            if (inputText == null) { return inputText; }
            string decryptedText = null;
            key = 256 - Math.Abs(key); //Calculate decryption key & get absolute value in case the key is negative
            for (int i = 0; i < inputText.Length; i++)
            {
                //Adds the decrypted character of the input string to the output string
                decryptedText += (char)((inputText[i] + key) % 256);
            }
            return decryptedText;
        }
    }
}
