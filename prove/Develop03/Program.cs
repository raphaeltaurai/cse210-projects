using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello the following is the memory verse!");
        // Load scriptures from a file
        ScriptureLibrary library = new ScriptureLibrary("scriptures.txt");
        Scripture scripture = library.GetRandomScripture();

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(1);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine("\nAll words are hidden! Goodbye!");
    }
}