using System;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        };

        DisplayWelcome();

        static string PromptUserName ()
        {
            Console.Write("Enter Username");
            return Console.ReadLine();
        };

        string userName = PromptUserName();

        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out int favoriteNumber))
            {
                return favoriteNumber;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return PromptUserNumber(); // Ask again if input is invalid
            }
        }

        int favoriteNumber = PromptUserNumber();

        static int SquareNumber(int number)
        {
            return number * number;
        }

        int squaredNumber = SquareNumber(favoriteNumber);

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"Hello, {userName}!, the square of your number is {squaredNumber}");
        }

        DisplayResult(userName,squaredNumber);

}
}