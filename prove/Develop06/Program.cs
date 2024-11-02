using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Recors Event");
            Console.WriteLine("  6. Quit");  
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                goalManager.CreateGoal();
            }

            else if (choice == "2")
            {
                goalManager.ListGoalDetails();
            }

            else if (choice == "3")
            {
                goalManager.SaveGoals();
                Console.WriteLine("Goals saved. ");
            }

            else if (choice == "4")
            {
                goalManager.LoadGoals();
                Console.WriteLine("Goals loaded.");
            }

            else if ( choice == "5")
            {
                goalManager.RecordEvent();
            }

            else if (choice == "6")
            {
                exit = true;
                Console.WriteLine("Goodbye! ");
            }

            else 
            {
                Console.WriteLine("Enter valid option. ");
            }
        }
    }
}