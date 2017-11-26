namespace Presents
{
    public class Chocolate : Product
    {
    public string Taste { get; private set; }

    public Chocolate(string name, int price, int count, string taste)
        {
            Name = name;
            Price = price;
            Count = count;
            Taste = taste;
        }
    }
}