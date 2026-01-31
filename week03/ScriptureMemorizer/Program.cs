using System;
// for exceeding the requirement,I had my program work with a library of scriptures rather than a single one. Choosing scriptures at random to present to the user
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptures.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."));
        scriptures.Add(new Scripture(new Reference("1 Nephi", 8, 1), "And it came to pass that we had gathered together all manner of seeds of every kind, both of grain of every kind, and also of the seeds of fruit of every kind."));
        
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        bool _isRunning = true;
        while (_isRunning)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input == "quit")
            {
                _isRunning = false;
            }

            if (scripture.IsCompletelyHidden())
            {
                _isRunning = false;
            }

            scripture.HideRandomWords(3);
        }

    }
}