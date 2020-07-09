using Homework__Serializing_and_Deserializing_.Entities;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Homework__Serializing_and_Deserializing_
{
    class Program
    {
        static string folderPath = @"..\..\..\OurData";
        static string filePath = folderPath + @"\myJson.json";

        static void Main(string[] args)
        {
            ReaderWriter rw = new ReaderWriter();
            Dog dogs = new Dog();


            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            if (!File.Exists(filePath))
                File.Create(filePath).Close();
            

            Console.WriteLine("Enter dog name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter dog age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter dog color");
            string color = Console.ReadLine();

            dogs.Name = name;
            dogs.Age = age;
            dogs.Color = color;


            string dogString = JsonConvert.SerializeObject(dogs);


            rw.WriteFile(filePath, dogString);
            Console.WriteLine(rw.ReadFile(filePath));






            Console.ReadLine();
        }
    }
}
