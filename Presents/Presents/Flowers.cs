namespace Presents
{
    public class Flowers : Product
    {
    public string Color { get; private set; }

    public Flowers(string name, int price, string color)
        {
            Name = name;
            Price = price;
            Color = color;
        }
    }
}