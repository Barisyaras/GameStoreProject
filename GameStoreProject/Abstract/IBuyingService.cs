using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    interface IBuyingService
    {
        bool Buy(Customer customer, Product product);
        bool BuywithCampaign(Customer customer, Campaign campaign, Product product);
    }
}
