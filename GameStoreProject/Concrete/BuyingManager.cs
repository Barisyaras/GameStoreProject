using System;
using System.Text;

namespace GameStoreProject
{
    public class BuyingManager : IBuyingService
    {
        public bool Buy(Customer customer, Product product)
        {
            Console.WriteLine(customer.FirstName+ " " + product.Name + "oyununu başarıyla almıştır.");
            return customer.HavetheGame = true;
        }

        public bool BuywithCampaign(Customer customer, Campaign campaign, Product product)
        {
            double number = product.Price - (product.Price * campaign.DiscountRate / 100);
            double campaignPrice = Math.Round(number, 2);
            Console.WriteLine(customer.FirstName+" " + product.Name + " oyununu başarıyla %"+ campaign.DiscountRate + " indirimle "+ campaignPrice + " TL'ye almıştır.");
            return customer.HavetheGame = true;
        }
    }
}

