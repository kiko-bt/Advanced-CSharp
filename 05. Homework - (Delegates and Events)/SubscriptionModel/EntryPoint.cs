using SubscriptionModel.Models;
using System;
using System.Threading;

namespace SubscriptionModel
{
    class EntryPoint
    {
        #region Markets and Users

        public static Market Vero = new Market()
        {
            Name = "Vero",
            CurrentPromotion = ProductType.Food,
            NewLocation = "Bul. Partizanski Odredi bb"
        };

        public static Market Tinex = new Market()
        {
            Name = "Tinex",
            CurrentPromotion = ProductType.Food,
            NewLocation = "Pero Nakov, Skopje 1000"
        };

        public static Market TehnoMarket = new Market()
        {
            Name = "Tehno Market",
            CurrentPromotion = ProductType.Electronics,
            NewLocation = "Pitu Guli br.59"
        };

        #endregion



        static void Main(string[] args)
        {

            User kiko = new User() { Name = "Hristijan", Age = 25, FavoriteType = ProductType.Drinks };
            User dejan = new User() { Name = "Dejan", Age = 28, FavoriteType = ProductType.Food };
            User ivo = new User() { Name = "Ivo", Age = 30, FavoriteType = ProductType.Electronics };


            ////Users subscribe to Vero for their promotions
            //Vero.SubscribeForPromotions(kiko.ReadPromotion, "kiko-bt@hotmail.com");
            //Vero.SubscribeForPromotions(dejan.ReadPromotion, "dejan-sk@gmail.com");
            //Vero.SubscribeForPromotions(ivo.ReadPromotion, "ivo-kostovski@hotmail.com");

            ////Users subscribe to Tinex for their promotions
            //Tinex.SubscribeForPromotions(kiko.ReadPromotion, "kiko-bt@hotmail.com");

            ////Users subscribe to TehnoMarket for their promotions
            //TehnoMarket.SubscribeForPromotions(dejan.ReadPromotion, "dejan-sk@gmail.com");
            //TehnoMarket.SubscribeForPromotions(ivo.ReadPromotion, "ivo-kostovski@hotmail.com");


            ////Vero is sending promotions to all its subscribers
            //Vero.SendPromotions();
            //Vero.CurrentPromotion = ProductType.Drinks;
            //Vero.UnSubscribeForPromotions(kiko.ReadPromotion, "Booooooring!");


            //Console.WriteLine(new string('=', 100));
            //Tinex.SendPromotions();
            //Tinex.CurrentPromotion = ProductType.Food;


            //Console.WriteLine(new string('=', 100));
            //TehnoMarket.SendPromotions();
            //TehnoMarket.UnSubscribeForPromotions(dejan.ReadPromotion, "Promotion to often!");
            //TehnoMarket.UnSubscribeForPromotions(ivo.ReadPromotion, "It is too expensive!");
            //TehnoMarket.SubscribeForPromotions(kiko.ReadPromotion, "kiko-bt@hotmail.com");



            //Thread.Sleep(3000);
            //Console.Clear();



            //Vero.SendPromotions();

            //Console.WriteLine(new string('=', 100));

            //Tinex.SendPromotions();

            //Console.WriteLine(new string('=', 100));

            //TehnoMarket.SendPromotions();



            //Vero.DisplayZhalbiIPoplaki();
            //Tinex.DisplayZhalbiIPoplaki();
            //TehnoMarket.DisplayZhalbiIPoplaki();

            //Console.Clear();
            //Thread.Sleep(4000);
            //Vero.SubscribeForInfo(kiko.ReadInfo, "kiko-bt@hotmail.com");
            //Vero.SendInfo();



            Console.Clear();
          
            

            Console.WriteLine("=========================== HOMEWORK ============================");
            //Requirements for homework
            //1.Implement a new event handler for informing all the subscribers for new locations about the markets
            //2.Implement a new listener methods that need to be subscriebed to the publisher event handler
            //3.Add new subscribers in Program.cs for that kind of information
            //4.Play with subscription and unsubscription of the event handler

            Vero.SubscribeForLocations(kiko.ReadInfoForLocation, "kiko-bt@hotmail.com");
            Tinex.SubscribeForLocations(dejan.ReadInfoForLocation, "dejan-sk@gmail.com");
            TehnoMarket.SubscribeForLocations(ivo.ReadInfoForLocation, "ivo-kostovski@hotmail.com");

            Vero.SendingNewLocation();
            Tinex.SendingNewLocation();
            TehnoMarket.SendingNewLocation();

            Console.Clear();
            Tinex.UnSubscribeForLocations(dejan.ReadInfoForLocation, "Spam");

            Vero.SubscribeForLocations(dejan.ReadInfoForLocation, "dejan-sk@gmail.com");
            Vero.SubscribeForLocations(ivo.ReadInfoForLocation, "ivo-kostovski@hotmail.com");
            Tinex.SubscribeForLocations(kiko.ReadInfoForLocation, "kiko-bt@hotmail.com");
            TehnoMarket.SubscribeForLocations(kiko.ReadInfoForLocation, "kiko-bt@hotmail.com");

            Console.Clear();

            Vero.SendingNewLocation();
            Tinex.SendingNewLocation();
            TehnoMarket.SendingNewLocation();


            Console.WriteLine(new string('-', 30));


            Console.WriteLine("Messages sent successfully!");




            Console.ReadLine();
        }
    }
}
