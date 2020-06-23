using Homework__Generics_and_Extension_Methods_.Helper;
using Homework__Generics_and_Extension_Methods_.Models;
using System;
using System.Linq;
using System.Threading;

namespace Homework__Generics_and_Extension_Methods_
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            PetStore<Cat> catStore = new PetStore<Cat>();
            PetStore<Dog> dogStore = new PetStore<Dog>();
            PetStore<Fish> fishStore = new PetStore<Fish>();

            catStore.Pets.Add(new Cat() { Name = "Lilly", Lazy = true, LivesLeft = 5, Age = 8, Type = "Persian" });
            catStore.Pets.Add(new Cat() { Name = " Lucy", Lazy = false, LivesLeft = 1, Age = 11, Type = "Egyptian Mau" });

            dogStore.Pets.Add(new Dog() { Name = "Rex", GoodBoi = true, FavoriteFood = "salmon", Age = 10, Type = "Beagle" });
            dogStore.Pets.Add(new Dog() { Name = "Jack", GoodBoi = false, FavoriteFood = "beef", Age = 7, Type = "Pit Bull" });

            fishStore.Pets.Add(new Fish() { Name = "Dory", Size = 8, Color = "orange", Age = 29, Type = "Neon Tetra" });
            fishStore.Pets.Add(new Fish() { Name = "Bubba", Size = 18, Color = "dark violet", Age = 47, Type = "Betta" });




            while (true)
            {
                Start:
                Console.WriteLine("Welcome To The Pet Store!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                catStore.PrintPets(600);
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Red;
                dogStore.PrintPets(600);
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Blue;
                fishStore.PrintPets(600);
                Console.ResetColor();


                Console.WriteLine(new string('-', 80));


                Console.WriteLine("Write your favorite pet name and buy it");
                string petName = Console.ReadLine();

                if (petName == null)
                {
                    Console.WriteLine("Sorry. We haven't that name in the Pet Store");
                }
                else
                {
                    Console.Clear();
                    catStore.BuyPet(petName);
                    dogStore.BuyPet(petName);
                    fishStore.BuyPet(petName);
                    goto Start;
                }

                break;
            }

           


    





            Console.ReadLine();
        }
    }
}
