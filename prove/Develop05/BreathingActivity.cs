public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base ("Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ",
                0)
    {

    }         
    
    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int timeElapsed = 0;

        while (timeElapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
            timeElapsed += 10;
        }

        DisplayEndingMessage();
    }
}