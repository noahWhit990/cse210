class Costume
{
    // attributes
    public string _headwear;
    public string _upperGarment;
    public string _lowerGarment;
    public string _footwear;
    public string _accessories;
    // behavior
    public void Output()
    {
        Console.WriteLine("Costume pieces:");
        Console.WriteLine($"Head: {_headwear}");
        Console.WriteLine($"Torso: {_upperGarment}");
        Console.WriteLine($"Legs: {_lowerGarment}");
        Console.WriteLine($"Feet: {_footwear}");
        Console.WriteLine($"Other: {_accessories}");
    }
}