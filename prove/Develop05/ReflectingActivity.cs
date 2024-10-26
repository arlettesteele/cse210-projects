public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectingActivity()
        : base ("Reflecting Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience.",
                0)
    
    {
        _prompts = new List<string>
        {
            "---Think of a time when you stood up for someone else.--",
            "---Think of a time when you did something really difficult.---",
            "---Think of a time when you helped someone in need.---",
            "---Think of a time when you did something truly selfless.---",
            "---Think of a time when you showed resilience in a challenging situation.---"
        };


        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        for (int i = 0; i < duration / 5; i++)
        {
            DisplayQuestions();
            ShowSpinner(2);
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);

        Thread.Sleep(5000);
    }


}
