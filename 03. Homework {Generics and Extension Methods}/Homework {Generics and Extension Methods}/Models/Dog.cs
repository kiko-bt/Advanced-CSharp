using System;
using System.Collections.Generic;
using System.Text;

namespace Homework__Generics_and_Extension_Methods_.Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        public override string PrintInfo()
        {
            return $"Hi! I'am {base.Name} - {base.Age} years old | {base.Type} dog.";
        }
    }
}
