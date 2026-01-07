using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        int firstDigit = int.Parse(userGrade[0].ToString());
        int secondDigit = int.Parse(userGrade[1].ToString());
        string sign = "";
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter ="C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (secondDigit >= 7 && firstDigit < 9)
        {
            sign = "+";
        }
        else if (secondDigit < 3 && firstDigit > 6)
        {
           sign = "-";
        }
        Console.WriteLine($"Your grade is {letter}{sign}");
        Console.WriteLine();
    }
}