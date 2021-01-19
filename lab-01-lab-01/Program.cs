using System;


namespace CS1405_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our kitchen. We will make a few foods today. \n");

            Vegatable veg1 = new Vegatable(){Color = "red", IsWashed = true};
            veg1.GetInfo();

            Vegatable veg2 = new Vegatable();
            veg2.Color = "green";
            veg2.IsWashed = false;
            veg2.GetInfo();

            Meat meat1 = new Meat(){SafeCookTemp = 200};
            meat1.GetInfo();

            Meat meat2 = new Meat();
            meat2.SafeCookTemp = 160;
            meat2.GetInfo();
            
            Carrot carrot1 = new Carrot(){isChopped = true};
            carrot1.GetInfo();

            Carrot carrot2 = new Carrot();
            carrot2.isChopped = false;
            carrot2.GetInfo();

            Steak steak1 = new Steak(){cookedPreference = "rare"};
            steak1.GetInfo();

            Steak steak2 = new Steak();
            steak2.cookedPreference = "medium";
            steak2.GetInfo();

            Potato potato1 = new Potato(){cookingMethod = "fried"};
            potato1.GetInfo();

            Potato potato2 = new Potato();
            potato2.cookingMethod = "boiled";
            potato2.GetInfo();

            Food.ThrowAwayFood();
            Console.WriteLine($"There are {Food.TotalCreated} foods created.");
            
        }
    }
}
