using System;

class Program
{
    static void Main(string[] args)
    {
        int runProgram = 1;
        Journal newJournal = new Journal();
        do
        {
            string userInput;
            Console.WriteLine("Please select one of the choices");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;
                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();
                newJournal.AddEntry(newEntry);
                newEntry.Display();
            }
            else if (userInput == "2")
            {
                newJournal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Enter the name of the file: ");
                string filename = Console.ReadLine();
                newJournal.LoadFromFIle(filename);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                newJournal.SaveToFile(filename);
            }
            else if (userInput == "5")
            {
                runProgram = 0;
            }
        }
        while (runProgram == 1);
    }
}