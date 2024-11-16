using System;

namespace strings_and_arrays
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string reversedSentence = ReverseSentence(sentence);

            Console.WriteLine("Reversed sentence: " + reversedSentence);
        }

        static string ReverseSentence(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] wordArray = words[i].ToCharArray();
                Array.Reverse(wordArray);
                words[i] = new string(wordArray);
            }

            return string.Join(" ", words);
        }
    }
}
