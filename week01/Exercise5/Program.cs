using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favourite number: ");
            int favouriteNumber = int.Parse(Console.ReadLine());
            return favouriteNumber;
        }
        static int SquareNumber(int number)
        {
            return number*number;
        }
        static void DisplayResult(string usersName, int squaredNumber)
        {
            Console.WriteLine($"{usersName}, the square of your number is {squaredNumber}");
        }

        // ill now call the functions here 
        DisplayWelcome();
        string userName = PromptUserName();
        int favouriteNum = PromptUserNumber();
        int squaredNumber = SquareNumber(favouriteNum); 
        DisplayResult(usersName: userName, squaredNumber: squaredNumber);
    }
}