using System;

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

        public override double GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }

            if (user.Spent < 600)
            {
                return Price * 0.9;
            }
            return Price * 0.8;
        }

        public override void GetWrite()
        {
            Console.WriteLine("Конфеты");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Количество: " + Count);
            Console.WriteLine("Вкус: " + Taste);
            Console.WriteLine(new String('-', 25));
        }
    }
}