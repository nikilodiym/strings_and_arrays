using System;

class Program
{
    static void Main(string[] args)
    {
        string text = @"To be, or not to be, that is the question,
Whether 'tis nobler in the mind to suffer
The slings and arrows of outrageous fortune,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
The heart-ache and the thousand natural shocks
That flesh is heir to, 'tis a consummation
Devoutly to be wish'd. To die, to sleep";

        string forbiddenWord = "die";

        string censoredText = CensorText(text, forbiddenWord, out int replacementsCount);

        Console.WriteLine("Modified text:");
        Console.WriteLine(censoredText);
        Console.WriteLine("\nStatistics:");
        Console.WriteLine($"{replacementsCount} replacements of the word '{forbiddenWord}'.");
    }

    static string CensorText(string text, string forbiddenWord, out int replacementsCount)
    {
        replacementsCount = 0;
        string[] lines = text.Split('\n');
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(forbiddenWord))
            {
                lines[i] = lines[i].Replace(forbiddenWord, new string('*', forbiddenWord.Length));
                replacementsCount++;
            }
        }
        return string.Join("\n", lines);
    }
}
