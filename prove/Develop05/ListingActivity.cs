
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random;

    public ListingActivity()
        : base ("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        List<string> userList = GetListFromUser(duration);

        _count = userList.Count;
        Console.WriteLine($"You Listed {_count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser(int duration)
    {
        List<string> items = new List<string>();
        DateTime endtime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endtime)
        {
            Console.Write(">> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        return items;
    }
}