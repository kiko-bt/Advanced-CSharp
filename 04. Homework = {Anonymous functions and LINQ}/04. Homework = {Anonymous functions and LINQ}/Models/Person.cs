using _04._Homework____Anonymous_functions_and_LINQ_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Homework____Anonymous_functions_and_LINQ_.Models
{
    public class Person
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Job Occupation { get; set; }
		public List<Dog> Dogs { get; set; }

		public Person(string firstName, string lastName, int age, Job occupation)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Occupation = occupation;
			Dogs = new List<Dog>();
		}
	}
}
