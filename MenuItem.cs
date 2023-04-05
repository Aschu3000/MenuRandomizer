using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MenuRandomizer
{
    internal class MenuItem
    {
        public static Random Randomizer = new Random();

        public string[] Proteins = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };

        public string[] Condiments = { "Yellow Mustard", "Brown Mustard", "Honey Mustard", "Mayo", "Relish", "French Dressing" };

        public string[] Breads = { "Rye", "White", "Wheat", "Pumpernickel", "A Roll" };

        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.01M);
            Price = price.ToString("c");
        }
    }

}
