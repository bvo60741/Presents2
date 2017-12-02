using System;

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

        public override double GetDiscountPrice(User user)
        {
            if (user.Date == 8)
            {
                return Price * 0.75;
            }
            return Price;
        }

        public override void GetWrite()
        {
            Console.WriteLine("Косметика");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Количество: " + Count);
            Console.WriteLine("Вид: " + Type);
            Console.WriteLine(new String('-', 25));
        }
    }
}