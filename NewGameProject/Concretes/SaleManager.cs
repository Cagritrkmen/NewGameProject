using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    class SaleManager : ISaleService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            int newPrice = game.GamePrice * (100 - campaign.DiscountRate) / 100;
            
            Console.WriteLine(gamer.FirstName +" adlı oyuncuya "+ game.GameName+ " adlı oyun "+campaign.CampaignName+ " kampanyasıyla "+ newPrice + " Tl'ye satılmıştır. ");
            Console.WriteLine("İndirim tutarı: "+ (game.GamePrice-newPrice)+"Tl'dir.");
        }
    }
}
