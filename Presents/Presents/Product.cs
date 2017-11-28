using System;

namespace Presents
{
    public class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public double Count { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            return Price;
        }
        public virtual void GetWrite()
        {
            Console.WriteLine("Подарок");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Количество: " + Count);
        }
    }
}