public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Goal type: ");
        string goalType = Console.ReadLine();

                Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description = Console.ReadLine();
        Console.Write("Points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (goalType == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (goalType == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times to complete goal? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points on completion: ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
            return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record:");
        ListGoalNames();
        Console.Write("Goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _score += _goals[goalIndex].RecordEvent();
            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
        
    }
}