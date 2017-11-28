using System;

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

        public override void GetWrite()
        {
            Console.WriteLine("Цветы");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Количество: " + Count);
            Console.WriteLine("Цвет: " + Color);
            Console.WriteLine(new String('-', 25));
        }
    }
}