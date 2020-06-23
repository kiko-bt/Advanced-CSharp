using System;

namespace _02._Exercise__Static_Classes_and_Polymorphism_
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Dog jack = new Dog(1, "John", "black", "American Bulldog");
            Dog lara = new Dog(2, "Jane", "white", "Akita");
            Dog mara = new Dog(3, "Mary", "white", "Fox Terrier");


            if (Dog.Validate(jack))
            {
                DogShelter.Dogs.Add(jack);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            if (Dog.Validate(lara))
            {
                DogShelter.Dogs.Add(lara);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            if (Dog.Validate(mara))
            {
                DogShelter.Dogs.Add(mara);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }


            DogShelter.PrintAll(500);


            Console.ReadLine();
        }
    }
}
