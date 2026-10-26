public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference()
    {
        _book = null;
        _chapter = 0;
        _startVerse = 0;
        _endVerse = 0;
    }
    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public void SetBook(string bookName)
    {
        _book = bookName;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetStartVerse(int verse)
    {
        _startVerse = verse;
    }

    public void SetEndVerse(int verse)
    {
        _endVerse = verse;
    }

    public void DisplayReference()
    {
        if(_endVerse == 0)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");
        }
    }

    public string GetDisplayString()
    {
        if(_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }  
    }
}