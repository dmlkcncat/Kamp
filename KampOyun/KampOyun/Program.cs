using KampOyun.Abstract;
using KampOyun.Concrete;
using KampOyun.Entities;
using System;

namespace KampOyun
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new CustomerManager();
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Damla";
            customer1.LastName = "Deniz";
            customer1.DateofBirth = new DateTime(1998 , 3, 3);
            customer1.Identity = "11111111111";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Hilal";
            customer2.LastName = "Nisa";
            customer2.DateofBirth = new DateTime(1999, 5, 6);
            customer2.Identity = "12313145632";

            baseCustomerManager.register(customer1);
           // baseCustomerManager.update(customer2);
           // baseCustomerManager.delete(customer2);

            CustomerManager customerManager = new CustomerManager();
            customerManager.CheckIfRealPerson(customer1);

            BaseGameManager baseGameManager = new GameManager();
            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Sims 4";
            game1.GameVersion = "Island Lıvınıng";
            game1.GamePrice = "350";

            // baseGameManager.GameBuy(game1, customer1);
            //baseGameManager.GameSell(game1, customer2);

            BaseCampaignManager baseCampaignManager = new CampaignManager();
            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.StartingDate = new DateTime(2021, 3, 4);
            campaign.DueDate = new DateTime(2021, 5, 6);
            campaign.CampaignValue = "%50";

            baseCampaignManager.Register(game1, campaign);
           // baseCampaignManager.Update(game1, campaign);
           // baseCampaignManager.Delete(game1, campaign);


       




            
            Console.ReadLine();
            
        }
    }
}
