using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> anotherPlanetList = new List<string>() { "Jupiter", "Saturn" };

            //AddRange method
            planetList.AddRange(anotherPlanetList);

            //Insert method
            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");

            //Add method
            planetList.Add("Pluto");

            //GetRange method
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            //Remove method
            planetList.Remove("Pluto");

            //RANDOM NUMBERS
            Random random = new Random();
            List<int> numbers = new List<int>
            {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            foreach (int value in numbers)
            {
                //Console.Write($"{value} ");
            }

            //Console.Write($"\n");

            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

                if (numbers.IndexOf(i) != -1)
                {
                    Console.WriteLine($"numbers list contains {i}");
                }
                else
                {
                    Console.WriteLine($"numbers list doesn't contains {i}");
                }

            }
        }
    }
}