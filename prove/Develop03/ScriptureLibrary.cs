public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary(string filePath)
    {
        _scriptures = new List<Scripture>();
        LoadFromFile(filePath);
    }

    private void LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    string referencePart = parts[0];
                    string text = parts[1];

                    string[] refParts = referencePart.Split(new[] { ' ', ':', '-' });
                    string book = refParts[0];
                    int chapter = int.Parse(refParts[1]);
                    int startVerse = int.Parse(refParts[2]);

                    if (refParts.Length == 4)
                    {
                        int endVerse = int.Parse(refParts[3]);
                        _scriptures.Add(new Scripture(new Reference(book, chapter, startVerse, endVerse), text));
                    }
                    else
                    {
                        _scriptures.Add(new Scripture(new Reference(book, chapter, startVerse), text));
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Scripture file not found!");
        }
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];
    }
}