using _04._Homework____Anonymous_functions_and_LINQ_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Homework____Anonymous_functions_and_LINQ_.Models
{
    public class Dog
    {
		public string Name { get; set; }
		public string Color { get; set; }
		public int Age { get; set; }
		public Race Race { get; set; }

		public Dog(string name, string color, int age, Race race)
		{
			Name = name;
			Color = color;
			Age = age;
			Race = race;
		}
	}
}
