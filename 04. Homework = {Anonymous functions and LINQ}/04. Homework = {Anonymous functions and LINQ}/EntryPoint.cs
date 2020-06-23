using _04._Homework____Anonymous_functions_and_LINQ_.DB;
using _04._Homework____Anonymous_functions_and_LINQ_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04._Homework____Anonymous_functions_and_LINQ_
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            List<Person> personsWithR = Info.people
                .Where(person => person.FirstName.StartsWith('R'))
                .OrderByDescending(x => x.Age)
                .ToList();

            personsWithR.ForEach(name => Console.WriteLine($"Persons firstname starting with 'R' and ordered by Age --->   {name.FirstName} {name.LastName}"));




            Console.WriteLine(new string('-', 100));




            //2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            List<Dog> brownDogs = Info.dogs
                .Where(dog => dog.Age > 3 && dog.Color.Equals("Brown"))
                .OrderBy(dog => dog.Age)
                .ToList();

            brownDogs.ForEach(dogs => Console.WriteLine($"Dogs with brown color and older than 3 years old --->   {dogs.Name}"));




            Console.WriteLine(new string('-', 100));




            //3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            List<Person> personsWithDog = Info.people.Where(persons => persons.Dogs.Count > 2)
                                                     .OrderByDescending(name => name.FirstName)
                                                     .ToList();

            personsWithDog.ForEach(person => Console.WriteLine($"Persons with more than 2 dogs and ordered by name --->   {person.FirstName} {person.LastName}"));




            Console.WriteLine(new string('-', 100));




            //4. Find and print all Freddy`s dogs names older than 1 year
            List<string> freddyDogNames = Info.people.Find(name => name.FirstName.Equals("Freddy")).Dogs.Where(dogs => dogs.Age > 1)
                                                      .Select(dogNames => dogNames.Name)
                                                      .ToList();

            freddyDogNames.ForEach(dogs => Console.WriteLine($"Freddy's dogs names older than 1 year --->   {dogs}"));




            Console.WriteLine(new string('-', 100));




            //5. Find and print Nathen`s first dog
            List<string> nathenFirstDog = Info.people
                                              .Where(name => name.FirstName.Equals("Nathen"))
                                              .Select(dogName => dogName.Dogs.FirstOrDefault().Name)
                                              .ToList();

            nathenFirstDog.ForEach(dog => Console.WriteLine($"Nathen`s first dog is --->   {dog}"));




            Console.WriteLine(new string('-', 100));




            //6. Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            List<string> allWhiteDogs = Info.people
                .Where(names => names.FirstName == "Cristofer" || names.FirstName == "Freddy" || names.FirstName == "Erin" || names.FirstName == "Amelia")
                .SelectMany(dogName => dogName.Dogs)
                .Where(dogColor => dogColor.Color.Equals("White"))
                .OrderBy(dog => dog.Name)
                .Select(dogs => dogs.Name)
                .ToList();         

            allWhiteDogs.ForEach(dogs => Console.WriteLine($"White dogs are --->   {dogs}"));





            Console.ReadLine();
        }
    }
}
