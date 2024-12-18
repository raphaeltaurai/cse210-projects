public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity helps you focus on the positive by listing items based on a prompt.";
        _prompts = new List<string>
        {
            "Who are the people you appreciate?",
            "What are your personal strengths?",
            "What are things that make you happy?",
            "Who are people that inspire you?"
        };
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userResponses.Add(input);
                _count++;
            }
        }

        return userResponses;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prompt: " + GetRandomPrompt());
        Console.WriteLine("Start listing items...");
        List<string> responses = GetListFromUser();
        Console.WriteLine($"\nYou listed {_count} items.");
        DisplayEndingMessage();
    }
}
