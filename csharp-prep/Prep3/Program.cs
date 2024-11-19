using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        string rnumber = magicNumber.ToString();
        string guess = "";

        

        while (guess != rnumber)
        {

        Console.Write("Guess the magic number: ");
        guess = Console.ReadLine();
        int magicGuess = int.Parse(guess);

        if (magicGuess < magicNumber)
        {
            Console.WriteLine("Higher!");
        }
        else if (magicGuess > magicNumber)
        {
            Console.WriteLine("Lower!");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        }
    }
}