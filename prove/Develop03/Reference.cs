public class Reference
{
    private  string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


///single scripture
    public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = -1;
        }
///  multiple scripture
    public Reference(string book, int chapter, int verse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
        }


///Display  
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }

        return $"{_book} {_chapter}:{_verse} - {_chapter}:{_endVerse}";
    }

}