using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to te Journal Program!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userInput = "";

        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.Write(prompt);
                string response = Console.ReadLine();

                Entry newEntry = new Entry (prompt, response);
                journal.AddEntry(newEntry);
            }
            else if (userInput == "2")
            {
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                journal.SaveToFile();
            }
            else if (userInput == "4")
            {
                journal.LoadFromFile();
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }        
    }
}
