public static class Cards
{
    public static readonly Dictionary<string, VirtualCard> cards = new Dictionary<string, VirtualCard>
    {
        ["1"] = new VirtualCard("1", "Card-Maria", 1000.00m, true, 5000.00m),
        ["2"] = new VirtualCard("2", "Card-Sofia", 500.00m, true, 2000.00m),
        ["3"] = new VirtualCard("3", "Card-Vo", 250.00m, false, 1000.00m),
        ["4"] = new VirtualCard("4", "Card-John", 750.00m, true, 3000.00m),
        ["5"] = new VirtualCard("5", "Card-Alice", 1500.00m, false, 4000.00m)
    };
}