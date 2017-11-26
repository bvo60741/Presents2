namespace Presents
{
    public class Jewelry : Product
    {
        public string Type { get; private set; }

        public Jewelry(string name, int price, int count, string type)
        {
            Name = name;
            Price = price;
            Count = count;
            Type = type;
        }
    }
}