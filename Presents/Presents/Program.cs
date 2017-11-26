using System;
using System.Collections.Generic;

namespace Presents
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User user = new User(
                "Marco",
                "Top street, DOM",
                50000,
                10000
            );
            Console.WriteLine("Список товаров:");
            //Flowers
            Flowers roseFlowers = new Flowers(
                "Роза",
                200,
                3,
                "Красный"
            );
            Console.WriteLine("Цветы");
            Console.WriteLine("Название: " + roseFlowers.Name);
            Console.WriteLine("Цена: " + roseFlowers.Price);
            Console.WriteLine("Количество: " + roseFlowers.Count);
            Console.WriteLine("Цвет: " + roseFlowers.Color);
            Console.WriteLine(new String('-', 25));

            Flowers tulipsFlowers = new Flowers(
                "Тюльпаны",
                400,
                5,
                "Желтый"
            );
            Console.WriteLine("Цветы");
            Console.WriteLine("Название: " + tulipsFlowers.Name);
            Console.WriteLine("Цена: " + tulipsFlowers.Price);
            Console.WriteLine("Количество: " + tulipsFlowers.Count);
            Console.WriteLine("Цвет: " + tulipsFlowers.Color);
            Console.WriteLine(new String('-', 25));

            Flowers orchidFlowers = new Flowers(
                "Орхидея",
                700,
                1,
                "Фиолетовый"
            );
            Console.WriteLine("Цветы");
            Console.WriteLine("Название: " + orchidFlowers.Name);
            Console.WriteLine("Цена: " + orchidFlowers.Price);
            Console.WriteLine("Количество: " + orchidFlowers.Count);
            Console.WriteLine("Цвет: " + orchidFlowers.Color);
            Console.WriteLine(new String('-', 25));

            //Candys
            Candy сhocolateCandy = new Candy(
                "Шоколад",
                300,
                2,
                "Белый шоколад"
            );
            Console.WriteLine("Конфеты");
            Console.WriteLine("Название: " + сhocolateCandy.Name);
            Console.WriteLine("Цена: " + сhocolateCandy.Price);
            Console.WriteLine("Количество: " + сhocolateCandy.Count);
            Console.WriteLine("Вкус: " + сhocolateCandy.Taste);
            Console.WriteLine(new String('-', 25));

            Candy lollipopsCandy = new Candy(
                "Леденцы",
                600,
                1,
                "Мятный"
            );
            Console.WriteLine("Конфеты");
            Console.WriteLine("Название: " + lollipopsCandy.Name);
            Console.WriteLine("Цена: " + lollipopsCandy.Price);
            Console.WriteLine("Количество: " + lollipopsCandy.Count);
            Console.WriteLine("Вкус: " + lollipopsCandy.Taste);
            Console.WriteLine(new String('-', 25));

            Candy marmaladeCandy = new Candy(
                "Мармелад",
                400,
                1,
                "Фруктовое ассорти"
            );
            Console.WriteLine("Конфеты");
            Console.WriteLine("Название: " + marmaladeCandy.Name);
            Console.WriteLine("Цена: " + marmaladeCandy.Price);
            Console.WriteLine("Количество: " + marmaladeCandy.Count);
            Console.WriteLine("Вкус: " + marmaladeCandy.Taste);
            Console.WriteLine(new String('-', 25));

            //Cosmetic
            Cosmetic pomadeCosmetic = new Cosmetic(
                "Inglot",
                1500,
                1,
                "Помада"
            );
            Console.WriteLine("Косметика");
            Console.WriteLine("Название: " + pomadeCosmetic.Name);
            Console.WriteLine("Цена: " + pomadeCosmetic.Price);
            Console.WriteLine("Количество: " + pomadeCosmetic.Count);
            Console.WriteLine("Вид: " + pomadeCosmetic.Type);
            Console.WriteLine(new String('-', 25));

            Cosmetic mascaraCosmetic = new Cosmetic(
                "Max Factor",
                1000,
                1,
                "Тушь для ресниц"
            );
            Console.WriteLine("Косметика");
            Console.WriteLine("Название: " + mascaraCosmetic.Name);
            Console.WriteLine("Цена: " + mascaraCosmetic.Price);
            Console.WriteLine("Количество: " + mascaraCosmetic.Count);
            Console.WriteLine("Вид: " + mascaraCosmetic.Type);
            Console.WriteLine(new String('-', 25));

            Cosmetic eyeshadowCosmetic = new Cosmetic(
                "Essense",
                1500,
                6,
                "Тени для век"
            );
            Console.WriteLine("Косметика");
            Console.WriteLine("Название: " + eyeshadowCosmetic.Name);
            Console.WriteLine("Цена: " + eyeshadowCosmetic.Price);
            Console.WriteLine("Количество: " + eyeshadowCosmetic.Count);
            Console.WriteLine("Вид: " + eyeshadowCosmetic.Type);
            Console.WriteLine(new String('-', 25));

            //Clothes
            Clothes tshirtClothes = new Clothes(
                "Supreme",
                4600,
                1,
                "Футболка"
            );
            Console.WriteLine("Одежда");
            Console.WriteLine("Название: " + tshirtClothes.Name);
            Console.WriteLine("Цена: " + tshirtClothes.Price);
            Console.WriteLine("Количество: " + tshirtClothes.Count);
            Console.WriteLine("Вид: " + tshirtClothes.Type);
            Console.WriteLine(new String('-', 25));

            Clothes shoesClothes = new Clothes(
                "Nike Air Max 1",
                9100,
                1,
                "Кроссовки"
            );
            Console.WriteLine("Одежда");
            Console.WriteLine("Название: " + shoesClothes.Name);
            Console.WriteLine("Цена: " + shoesClothes.Price);
            Console.WriteLine("Количество: " + shoesClothes.Count);
            Console.WriteLine("Вид: " + shoesClothes.Type);
            Console.WriteLine(new String('-', 25));

            Clothes jeansClothes = new Clothes(
                "gloria Jeans",
                2500,
                1,
                "Джинсы"
            );
            Console.WriteLine("Одежда");
            Console.WriteLine("Название: " + jeansClothes.Name);
            Console.WriteLine("Цена: " + jeansClothes.Price);
            Console.WriteLine("Количество: " + jeansClothes.Count);
            Console.WriteLine("Вид: " + jeansClothes.Type);
            Console.WriteLine(new String('-', 25));

            //Jewelry
            Jewelry pendantJewelry = new Jewelry(
                "Золото",
                2500,
                1,
                "Подвеска"
            );
            Console.WriteLine("Ювелирное украшение");
            Console.WriteLine("Название: " + pendantJewelry.Name);
            Console.WriteLine("Цена: " + pendantJewelry.Price);
            Console.WriteLine("Количество: " + pendantJewelry.Count);
            Console.WriteLine("Вид: " + pendantJewelry.Type);
            Console.WriteLine(new String('-', 25));

            Jewelry ringJewelry = new Jewelry(
                "Серебро",
                1200,
                1,
                "Колько"
            );
            Console.WriteLine("Ювелирное украшение");
            Console.WriteLine("Название: " + ringJewelry.Name);
            Console.WriteLine("Цена: " + ringJewelry.Price);
            Console.WriteLine("Количество: " + ringJewelry.Count);
            Console.WriteLine("Вид: " + ringJewelry.Type);
            Console.WriteLine(new String('-', 25));

            Jewelry earringsJewelry = new Jewelry(
                 "Белое золото",
                 8000,
                 2,
                 "Сережки"
             );
            Console.WriteLine("Ювелирное украшение");
            Console.WriteLine("Название: " + earringsJewelry.Name);
            Console.WriteLine("Цена: " + earringsJewelry.Price);
            Console.WriteLine("Количество: " + earringsJewelry.Count);
            Console.WriteLine("Вид: " + earringsJewelry.Type);
            Console.WriteLine(new String('-', 25));

            Product[] products = new Product[]
            {
                roseFlowers, tulipsFlowers, orchidFlowers, сhocolateCandy, lollipopsCandy, marmaladeCandy, pomadeCosmetic, mascaraCosmetic, eyeshadowCosmetic, tshirtClothes, shoesClothes,
                jeansClothes, pendantJewelry, ringJewelry, earringsJewelry
            };

            Informer informer = new Informer();
            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуй {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);
                if (productNumber >= 0 && productNumber < products.Length)
                {
                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }
                }
                else
                {
                    Console.WriteLine("Такого товара нет");
                }
            }
        }
    }
}