public class Scripture
{
    private string _scripture;
    private List<Word> _words = new List<Word>();

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
        string[] parts = scripture.Split(" ");

        foreach(string part in parts)
        {
            Word word = new Word();
            word.SetText(part);
            _words.Add(word);
        }
    }

    public string GetScripture()
    {
        return _scripture;
    }

    public bool AllHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.GetHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string Memorize()
    {
        Random random = new Random();
        int i = 0;
        while(i < 3 && !AllHidden())
        {
            int index = random.Next(_words.Count);
            if(!_words[index].GetHidden())
            {
                _words[index].Hide();
                i++;
            }
        }

        _scripture = "";

        foreach(Word word in _words)
        {
            _scripture += $"{word.GetText()} ";
        }
        return _scripture;
    }
}