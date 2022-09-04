using System;
using System.Text;

namespace GameStoreProject
{
    interface ICampaignService
    {
        void Add(Campaign camping);
        void Delete(Campaign camping);
        void Update(Campaign camping);
    }
}
