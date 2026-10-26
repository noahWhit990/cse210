public class Word
{
    private string _text;
    private bool _isHidden;
    
    public void SetText(string word)
    {
        _text = word;
    }

    public string GetText()
    {
        return _text;
    }

    public void Hide()
    {
        int length = _text.Length;
        _text = "";
        for(int i = 0; i < length; i++)
        {
            _text += "_";
        }
        _isHidden = true;
    }

    public bool GetHidden()
    {
        return _isHidden;
    }

    public string GetDisplayString()
    {
        return _text;
    }
}