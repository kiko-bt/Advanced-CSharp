using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _02._Exercise__Static_Classes_and_Polymorphism_
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Race { get; set; }

        public Dog(int id, string name, string color, string race)
        {
            this.Id = id;
            this.Name = name;
            this.Color = color;
            this.Race = race;
        }

        public void Bark()
        {
            Console.WriteLine("Bark bark...");
        }

        public static bool Validate(Dog dogs)
        {
            if (dogs.Id > 0 && dogs.Name.Length >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
