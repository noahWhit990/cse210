class Program
{
    static void Main(string[] args)
    {
        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume();
        detective._headwear = "Fedora";
        detective._upperGarment = "Trenchcoat";
        detective._lowerGarment = "Slacks";
        detective._footwear = "Dress Shoes";
        detective._accessories = "Fingerprint Kit";
        myCostumes.Add(detective);

        Costume nurse = new Costume();
        nurse._headwear = "Hairnet";
        nurse._upperGarment = "Scrubs";
        nurse._lowerGarment = "Scrubs";
        nurse._footwear = "Orthopedic Shoes";
        nurse._accessories = "Surgical Mask";
        myCostumes.Add(nurse);

        foreach (Costume c in myCostumes)
        {
            c.Output();
        }
    }
}
