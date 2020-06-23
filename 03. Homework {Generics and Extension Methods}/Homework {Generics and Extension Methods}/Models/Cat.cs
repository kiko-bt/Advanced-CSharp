using System;
using System.Collections.Generic;
using System.Text;

namespace Homework__Generics_and_Extension_Methods_.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }


        public override string PrintInfo()
        {
            return $"Hi! I'am {base.Name} - {base.Age} years old | {base.Type} cat.";
        }
    }
}
