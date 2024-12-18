public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity helps you relax by breathing in and out slowly.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 8; i++) // 8 seconds for each cycle
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}
