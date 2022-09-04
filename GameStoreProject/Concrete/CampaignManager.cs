using System;

namespace GameStoreProject
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign camping)
        {
            Console.WriteLine(camping.Name + " isimli kampanya eklendi");
        }

        public void Delete(Campaign camping)
        {
            Console.WriteLine(camping.Name + " isimli kampanya silindi");
        }

        public void Update(Campaign camping)
        {
            Console.WriteLine(camping.Name + " isimli kampanya güncellendi");
        }
    }
}
