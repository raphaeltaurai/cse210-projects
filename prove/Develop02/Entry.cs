public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }

    public string Display()
    {
        return $"Date: {_date}\nPrompt: {_promptText}\nResponse: {_entryText}\n";
    }

    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromString(string line)
    {
        var parts = line.Split('|');
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}
