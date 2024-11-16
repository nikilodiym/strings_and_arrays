using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_and_arrays
{
    internal class task15
    {
        public static string ChangeSentenceCase(string input)
        {
            string[] sentences = input.Split('.');
            StringBuilder result = new StringBuilder();

            foreach (string sentence in sentences)
            {
                if (!string.IsNullOrWhiteSpace(sentence))
                {
                    string trimmedSentence = sentence.Trim();
                    if (trimmedSentence.Length > 0)
                    {
                        char firstChar = char.ToUpper(trimmedSentence[0]);
                        string modifiedSentence = firstChar + trimmedSentence.Substring(1);
                        result.Append(modifiedSentence + ". ");
                    }
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
