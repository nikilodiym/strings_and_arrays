using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task12
    {
        public static string Encrypt(string input, int shift)
        {
            string encryptedText = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = (char)(((c - 'A') + shift) % 26 + 'A');
                    encryptedText += encryptedChar;
                }
                else
                {
                    encryptedText += c;
                }
            }
            return encryptedText;
        }

        public static string Decrypt(string input, int shift)
        {
            string decryptedText = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char decryptedChar = (char)(((c - 'A') - shift + 26) % 26 + 'A');
                    decryptedText += decryptedChar;
                }
                else
                {
                    decryptedText += c;
                }
            }
            return decryptedText;
        }
    }
}
