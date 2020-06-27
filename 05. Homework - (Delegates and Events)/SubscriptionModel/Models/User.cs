using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionModel.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ProductType FavoriteType { get; set; }

        public void ReadPromotion(ProductType product)
        {
            Console.WriteLine($"Mr/Ms: {Name}, the product {product} is on sale!");
            //if (product == FavoriteType) Console.WriteLine("My FAVORITE!");
        }

        public void ReadInfo(string message)
        {
            Console.WriteLine($"Dear {Name}, here are the working hoursfor our market!");
        }

        public void ReadInfoForLocation(string name, string location)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"*Dear {Name}, we're just excited to share the good news of our new location of {name} markets!\n-Here is a new location | {location}");
            Console.ResetColor();
        }
    }
}
