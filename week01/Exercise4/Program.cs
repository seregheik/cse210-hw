using System;

class Program
{
    static void Main(string[] args)
    {
       int run = 1;
       float sum = 0;
       double average = 0;
       float largestNumber = 0;
       bool findSmallestPositiveNumber = true;
       int smallestPositiveNumber = 0;
       List<int> numbers = new List<int>();
       Console.WriteLine("Enter a list of numbers, type 0 when  finished.");
       do
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                run = 0;
            }
        } while (run == 1);
        numbers.Sort();
        foreach (int item in numbers)
        {
            sum += item;
            if (findSmallestPositiveNumber == true && smallestPositiveNumber == 0)
            {
                if (item > 0)
                {
                    smallestPositiveNumber = item;
                    findSmallestPositiveNumber = false;
                }
            }
        }

        average = sum/numbers.Count;
        
        largestNumber = numbers[numbers.Count - 1];
        
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largestNumber}");
        Console.WriteLine($"smallest positive number is {smallestPositiveNumber}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}