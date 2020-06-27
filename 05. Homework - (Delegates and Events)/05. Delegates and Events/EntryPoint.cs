using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _05._Delegates_and_Events
{
    class EntryPoint
    {
        //Declaring Delegates
        //This is a signature of any method that returns void and accepts string input parameter
        public delegate void SayDelegate(string message);


        public delegate int NumbersDelegate(int num1, int num2);


        //Custom generic delegate!
        //public delegate bool Filter<T>(T item);


        static void Main(string[] args)
        {

            #region Instantiating a delegate with methods

            SayDelegate hello = new SayDelegate(SayHello);

            SayDelegate bye = new SayDelegate(SayBye);


            //Using a delegates ( Points to methods )
            hello("Hristijan");
            bye("Hristijan");

            hello("Dejan");
            bye("Dejan");

            #endregion


            Thread.Sleep(2000);


            #region Passing method to an input parameter of type delegate parameter
            SayWhatever("Ivo", SayHello);
            SayWhatever("Bob", SayBye);


            Thread.Sleep(2000);

            //Send method as input parameter to other method by using lambda expression - in one line (as anonymous method)
            SayWhatever("John", x => Console.WriteLine($"Woow {x}"));

            //Send method as input parameter to other method by using lambda expression - with own scope (as anonymous method)
            SayWhatever("Ann", x =>
            {
                if (x == "Ann")
                {
                    Console.WriteLine($"Ohhh {x} it's you!");
                }
                else
                {
                    Console.WriteLine($"Stuff with {x}");
                    Console.WriteLine($"Other stuff with {x}");
                }
            });

            #endregion


            #region Making a higher order functions
            Console.WriteLine("NUMBER MASTER! IT IS REALLY MASTER AT NUMBERS!");

            NumberMaster(10, 20, (x, y) => x + y);
            NumberMaster(134, 112, (x, y) => x - y);
            NumberMaster(2, 5, (x, y) => 0);
            NumberMaster(22, 33, (x, y) =>
            {
                if (x > y)
                    return y;
                return x;
            });

            //Filter<int> filter = new Filter<int>(IsGreaterThanTen);

            #endregion


            Console.ReadLine();
        }


        public static void SayHello(string person)
        {
            Console.WriteLine($"Hello {person}!");
        }


        public static void SayBye(string person)
        {
            Console.WriteLine($"Bye {person}!");
        }


        public static void SayWhatever(string whatever, SayDelegate sayDelegate)
        {
            Console.WriteLine("This message comes from chat bot:");
            sayDelegate(whatever);
        }


        public static void NumberMaster(int num1, int num2, NumbersDelegate numbersDelegate) 
        {
            Console.WriteLine($"The result is: {numbersDelegate(num1, num2)}");
        }


        //Method for demo purpose for instantiating the generic delegate
        public static bool IsGreaterThanTen(int item)
        {
            if (item > 10)
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
