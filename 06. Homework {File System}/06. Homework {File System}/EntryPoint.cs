using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace _06._Homework__File_System_
{
    class EntryPoint
    {
        static string appPath = @"..\..\..\";
        static string folderPath = appPath + "Exercise";
        static string filePath = folderPath + @"\calculations.txt";


        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the sum of two integers");
            Thread.Sleep(2000);


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Enter first number");
                    int number1 = int.Parse(Console.ReadLine());

                    Console.WriteLine(new string('-', 20));

                    Console.WriteLine("Enter second number");
                    int number2 = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine(Calculate(number1, number2));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                break;
            }




            Console.ReadLine();
        }

        static string Calculate(int num1, int num2)
        {
            int result = num1 + num2;
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"The result of {num1} + {num2} is {result} | Time stamp: {DateTime.Now.ToLocalTime()}");
            }
            return $"{num1} + {num2} = {result}";
        }
    }
}
