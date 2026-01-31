using System;
using System.IO.Pipelines;

// for exceeding the requirement, i made the program automatically track the last saved file by the user and prompt. At launch of the program, it checks if the user has previously saved a journal file if the user wants to continue with the same file. If the user enters yes the program will automatically load the last saved file and if the user enters anything else, the program wont load the last saved file and will start afresh
class Program
{
    static void Main(string[] args)
    {
        int runProgram = 1;
        Journal newJournal = new Journal();
        LastSave newLastSave = new LastSave();
        do
        {
            
            string userInput;
            string lastSavedFile = newLastSave.LoadLastSavedFile();
            string response ="no";
            if (lastSavedFile != "No last save" && newLastSave._askLastSave)
            {
                Console.WriteLine("write yes if you want to continue with the previous list you worked on? ");
                response = Console.ReadLine();
                newLastSave._askLastSave = false;                
            }
            if (response == "yes") {
                newJournal.LoadFromFIle(lastSavedFile);
            }

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
                newLastSave.SaveLastSave(filename);
                newJournal.SaveToFile(filename);
                newLastSave._askLastSave = false;   
            }
            else if (userInput == "5")
            {
                runProgram = 0;
            }
        }
        while (runProgram == 1);
    }
}