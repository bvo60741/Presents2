namespace Presents
{
    public class Candy : Product
    {
    public string Taste { get; private set; }

    public Candy(string name, int price, int count, string taste)
        {
            Name = name;
            Price = price;
            Count = count;
            Taste = taste;
        }
    }
}