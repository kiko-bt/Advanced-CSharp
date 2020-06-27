using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SubscriptionModel.Models
{
    //This class Market will be the publisher
    //This class sends messages to all objects that subscribe for getting such messages
    public class Market
    {
        public delegate void PromotionSender(ProductType product);
        public event PromotionSender PromotionsHandler;


        public delegate void InformationSender(string message);
        public event InformationSender InformationHandler;

        public delegate void NewLocationSender(string message, string location);
        public event NewLocationSender NewLocationHandler;



        public string Name { get; set; }
        public ProductType CurrentPromotion { get; set; }
        public List<string> ZhalbiIPoplaki { get; set; }
        public List<string> Emails { get; set; }
        public string NewLocation { get; set; }


        public Market()
        {
            this.ZhalbiIPoplaki = new List<string>();
            this.Emails = new List<string>();
        }

        //A method that does some work ---> Sends promotions
        //Thread.Sleep(3000) simulates that something is being done for 3 seconds
        public void SendPromotions()
        {
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{Name} is sending promotion for {CurrentPromotion}");
            Console.WriteLine("...Sending");
            Thread.Sleep(3000);
            Send();
        }


        public void SendInfo()
        {
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{Name} is sending information for working hours");
            Console.WriteLine("...Sending");
            Console.WriteLine("Working hours!");
        }


        //The event is executed here, Informing all the methods that subscribed with some value (currentPromotion in our case)
        private void Send()
        {
            PromotionsHandler(CurrentPromotion);
        }

        public void SubscribeForPromotions(PromotionSender subscriber, string email)
        {
            PromotionsHandler += subscriber;
            Emails.Add(email);
        }

        public void UnSubscribeForPromotions(PromotionSender subscriber, string reason)
        {
            PromotionsHandler -= subscriber;
            ZhalbiIPoplaki.Add(reason);
        }


        public void SubscribeForInfo(InformationSender subscriber, string email)
        {
            InformationHandler += subscriber;
            Emails.Add(email);
        }

        public void UnSubscribeForInfo(InformationSender subscriber, string reason)
        {
            InformationHandler -= subscriber;
            ZhalbiIPoplaki.Add(reason);
        }

        public void DisplayZhalbiIPoplaki()
        {
            Console.WriteLine($"[{Name}] ZHALBI I POPLAKI:");
            ZhalbiIPoplaki.ForEach(Console.WriteLine);
        }


        private void SendLocation()
        {
            NewLocationHandler(Name, NewLocation);
        }

        public void SendingNewLocation()
        {
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{Name} promote new location {NewLocation}");
            Console.WriteLine("...Sending");
            Thread.Sleep(3000);
            SendLocation();
        }


        public void SubscribeForLocations(NewLocationSender newLocation, string email)
        {
            NewLocationHandler += newLocation;
            Emails.Add(email);
        } 

        public void UnSubscribeForLocations(NewLocationSender newLocation, string reason)
        {
            NewLocationHandler -= newLocation;
            ZhalbiIPoplaki.Add(reason);
        }


    }


    public enum ProductType
    {
        Food = 1,
        Cosmetics,
        Drinks,
        Electronics,
        Other
    }

}
