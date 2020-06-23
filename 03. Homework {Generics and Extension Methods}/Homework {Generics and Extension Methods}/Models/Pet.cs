using System;
using System.Collections.Generic;
using System.Text;

namespace Homework__Generics_and_Extension_Methods_.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public abstract string PrintInfo();
    }
}
