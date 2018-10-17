using System;
using Zoo.Classes;

namespace Zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PopulateZoo();
        }

        public static void PopulateZoo()
        {
            Lion mufasa = new Lion();
            Lion simba = new Lion();
            Eagle baldie = new Eagle();
            Ostrich matilda = new Ostrich();
            HoneyBee barry = new HoneyBee();
            Crab sebastian = new Crab();
            
            Console.WriteLine("A lion says: " + mufasa.Sound());
            Console.WriteLine("An eagle says: " + baldie.Sound());
            Console.WriteLine($"An ostrich can lay an average of {matilda.AverageEggsLaid()} eggs.");
            Console.WriteLine($"{barry.Fly()}... Bees can fly!");
            Console.WriteLine($"Crabs love to eat {sebastian.Nutrition()}");
        }
    }
}
