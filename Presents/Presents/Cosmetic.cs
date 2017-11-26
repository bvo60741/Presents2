namespace Presents
{
    public class Cosmetic : Product
    {
        public string Type { get; private set; }

        public Cosmetic(string name, int price, int count, string type)
        {
            Name = name;
            Price = price;
            Count = count;
            Type = type;
        }
    }
}