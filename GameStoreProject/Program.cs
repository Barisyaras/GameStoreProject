using System;

namespace GameStoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Barış";
            customer.Surname = "Yaraş";
            customer.NationalityId = "12345678910";
            customer.Id = 1;
            customer.HavetheGame = false;

            Product product = new Product();
            product.Name = "Crazy Horse 2";
            product.Price = 256;
            product.Id = 1;

            Campaign campaign = new Campaign();
            campaign.Name = "Alan yaşadı indirimi";
            campaign.DiscountRate = 29;
            campaign.Id = 1;


            PersonCheckService personCheckService = new PersonCheckService();
            personCheckService.CheckIfRealPearson(customer);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Update(customer);
            customerManager.Delete(customer);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            BuyingManager buyingManager = new BuyingManager();
            buyingManager.Buy(customer, product);
            buyingManager.BuywithCampaign(customer, campaign, product);
        }
    }
}
