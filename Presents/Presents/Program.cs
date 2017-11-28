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
                20000,
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

            Flowers tulipsFlowers = new Flowers(
                "Тюльпаны",
                400,
                5,
                "Желтый"
            );

            Flowers orchidFlowers = new Flowers(
                "Орхидея",
                700,
                1,
                "Фиолетовый"
            );

            roseFlowers.GetWrite();
            tulipsFlowers.GetWrite();
            orchidFlowers.GetWrite();

            //Candys
            Candy сhocolateCandy = new Candy(
                "Шоколад",
                300,
                2,
                "Белый шоколад"
            );

            Candy lollipopsCandy = new Candy(
                "Леденцы",
                600,
                1,
                "Мятный"
            );

            Candy marmaladeCandy = new Candy(
                "Мармелад",
                400,
                1,
                "Фруктовое ассорти"
            );

            сhocolateCandy.GetWrite();
            lollipopsCandy.GetWrite();
            marmaladeCandy.GetWrite();

            //Cosmetic
            Cosmetic pomadeCosmetic = new Cosmetic(
                "Inglot",
                1500,
                1,
                "Помада"
            );

            Cosmetic mascaraCosmetic = new Cosmetic(
                "Max Factor",
                1000,
                1,
                "Тушь для ресниц"
            );

            Cosmetic eyeshadowCosmetic = new Cosmetic(
                "Essense",
                1500,
                6,
                "Тени для век"
            );

            pomadeCosmetic.GetWrite();
            mascaraCosmetic.GetWrite();
            eyeshadowCosmetic.GetWrite();

            //Clothes
            Clothes tshirtClothes = new Clothes(
                "Supreme",
                4600,
                1,
                "Футболка"
            );

            Clothes shoesClothes = new Clothes(
                "Nike Air Max 1",
                9100,
                1,
                "Кроссовки"
            );

            Clothes jeansClothes = new Clothes(
                "gloria Jeans",
                2500,
                1,
                "Джинсы"
            );

            tshirtClothes.GetWrite();
            shoesClothes.GetWrite();
            jeansClothes.GetWrite();

            //Jewelry
            Jewelry pendantJewelry = new Jewelry(
                "Золото",
                2500,
                1,
                "Подвеска"
            );           

            Jewelry ringJewelry = new Jewelry(
                "Серебро",
                1200,
                1,
                "Колько"
            );

            Jewelry earringsJewelry = new Jewelry(
                 "Белое золото",
                 8000,
                 2,
                 "Сережки"
             );

            pendantJewelry.GetWrite();
            ringJewelry.GetWrite();
            earringsJewelry.GetWrite();

            Product[] products = new Product[]
            {
                roseFlowers, tulipsFlowers, orchidFlowers, сhocolateCandy, lollipopsCandy, marmaladeCandy, pomadeCosmetic, mascaraCosmetic, eyeshadowCosmetic, tshirtClothes, shoesClothes,
                jeansClothes, pendantJewelry, ringJewelry, earringsJewelry
            };

            Informer informer = new Informer();
            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуй, {user.Name} ваш баланс {user.Balance}");

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