using System;

namespace DinerMax3000
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";

            summerMenu.AddMenuItem("Salmon", "Fresh Salmon", 02.50);
            summerMenu.HospitalDirections = "Right around the corner";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code";
            outsideDrinks.AddMenuItem("Marguerita", "Lemon and vodka", 30.50);
            

            Order HungryGuest = new Order();

            for (int x = 0; x <= summerMenu.items.Count-1; x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                Console.WriteLine(summerMenu.items[x].Title);
                Console.WriteLine(summerMenu.items[x].Description);
                Console.WriteLine(summerMenu.items[x].Price);
            }
       
            Console.ReadKey();

        }
    }
}
