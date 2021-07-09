using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanye eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanye silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanye güncellendi");
        }
    }
}
