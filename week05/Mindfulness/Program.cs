using System;
using System.Collections.Generic;
    //  for exceeding the requirements,I implemented a log to keep track of how many times each activity was performed in the current session.
    // This log is displayed to the user before they quit the program.

class Program
{
    static Dictionary<string, int> activityLog = new Dictionary<string, int>
    {
        { "Breathing Activity", 0 },
        { "Reflection Activity", 0 },
        { "Listing Activity", 0 }
    };
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                activityLog["Breathing Activity"]++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                activityLog["Reflection Activity"]++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                activityLog["Listing Activity"]++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nActivity Log for this session:");
                foreach (var entry in activityLog)
                {
                    Console.WriteLine($"  {entry.Key}: {entry.Value} times");
                }
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}