namespace Presents
{
    public class Flowers : Product
    {
    public string Color { get; private set; }

    public Flowers(string name, int price, int count, string color)
        {
            Name = name;
            Price = price;
            Count = count;
            Color = color;
        }

    public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }
    }
}