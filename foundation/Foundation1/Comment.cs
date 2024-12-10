public class Comment
{
    private string _namePerson;
    private string _text;

    public Comment(string userName, string text)
    {
        _namePerson = userName;
        _text = text;
    }

    public string DisplayComment()
    {
        return $"{_namePerson}: {_text}'";
    }
}