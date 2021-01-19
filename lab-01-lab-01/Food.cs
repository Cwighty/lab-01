using System;

namespace CS1405_Lab
{
    public class Food
    {
        public static int TotalCreated = 0;
        public bool EatenRaw;
        public int CaloriesPerServing;

        public Food()
        {
            TotalCreated++;
        }

        public static void ThrowAwayFood()
        {
            TotalCreated--;
        }

    }


    class Vegatable : Food
    {
        public static int TotalVegatables = 0;

        public string Color { get; set; }
        public bool IsWashed { get; set; }


        public Vegatable()
        {
            TotalVegatables++;
        }
        public static void ThrowAwayVegatable()
        {
            TotalVegatables--;
            Food.ThrowAwayFood();
        }

        public void GetInfo()
        {
            Console.WriteLine($"This vegatable is {Color} and {(IsWashed ? "is washed" : "isn't washed")}.");
        }

    }

    class Meat : Food
    {
        public static int TotalMeat = 0;

        public int SafeCookTemp {get; set;}
        public Meat()
        {
            TotalMeat++;
        }

        public static void ThrowAwayMeat()
        {
            TotalMeat--;
            Food.ThrowAwayFood();
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"This meats cooking temp is {SafeCookTemp} degrees.");
        }
    }

    class Steak : Meat
    {
        public string cookedPreference;
        
        
        public void GetInfo()
        {
            Console.WriteLine($"This meats cooking preference is {cookedPreference} degrees.");
        }

    }

    class Carrot : Vegatable
    {
        public bool isChopped;

        public void GetInfo()
        {
            Console.WriteLine($"This carrot {(isChopped ? "is chopped" : "isn't chopped")}.");
        }


    }

    class Potato : Vegatable
    {
        public string cookingMethod;

        public void GetInfo()
        {
            Console.WriteLine($"This potato is {cookingMethod}.");
        }


    }
}


