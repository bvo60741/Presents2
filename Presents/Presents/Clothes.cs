namespace Presents
{
    public class Clothes : Product
    {
        public string Type { get; private set; }

        public Clothes(string name, int price, int count, string type)
        {
            Name = name;
            Price = price;
            Count = count;
            Type = type;
        }
    }
}