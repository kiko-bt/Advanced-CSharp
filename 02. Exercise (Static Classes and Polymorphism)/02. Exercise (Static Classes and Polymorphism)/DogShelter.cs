using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _02._Exercise__Static_Classes_and_Polymorphism_
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog>();
        }

        public static void PrintAll(int sleep)
        {
            foreach (var dog in Dogs)
            {
                Console.WriteLine($"{dog.Id}. {dog.Name} | {dog.Color} |  {dog.Race}");
                Thread.Sleep(sleep);
            }
        }
    }
}
