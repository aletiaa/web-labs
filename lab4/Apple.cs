public class Apple : Fruit
{
    public Apple(string name, double price, string color) 
        : base(name, price)
    {
        Color = color;
    } 

    public string Color { get; }

    public override string[] GetProducingCountries()
    {
        return new []
        {
            "Ukraine",
            "Italy",
            "Lithuania"
        };
    }
}