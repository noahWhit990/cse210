class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public bool _favorite;
    // behaviors
    public void Display()
    {
        if (_favorite == true)
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response} - Favorite");
        }
        else
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}");
        }
    }
}