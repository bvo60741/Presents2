using System;

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

        public override double GetDiscountPrice(User user)
        {
            if (Name[0] == 'З')
            {
                return Price * 0.6;
            }
            return Price;
        }

        public override void GetWrite()
        {
            Console.WriteLine("Ювелирное украшение");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Количество: " + Count);
            Console.WriteLine("Вид: " + Type);
            Console.WriteLine(new String('-', 25));
        }
    }
}