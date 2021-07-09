using System;

namespace NewGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                BirthYear = 2002,
                FirstName = "Çağrı",
                LastName = "Türkmen",
                Id = 1,
                NationalityId = "12345678901"
            };
            Gamer gamer2 = new Gamer()
            {
                BirthYear = 2007,
                FirstName = "Hüseyin Kağan",
                LastName = "Türkmen",
                Id = 2,
                NationalityId = "1234567891"
            };
            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer2);
            //---------------------------------------------------Oyun Kismi--------------------------------------------//

            Game game1 = new Game() { GameName = "PlayerUnkown's UnderGround", GamePrice = 90 };
            Game game2 = new Game() { GameName = "Forza Horizon 4", GamePrice = 45 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game2);
            //---------------------------------------------------Kampanya Kismi--------------------------------------------//
            Campaign campaign1 = new Campaign() { CampaignName = "Yaz İndirimi", DiscountRate = 50 };
            Campaign campaign2 = new Campaign() { CampaignName = "Kış İndirimi", DiscountRate = 25 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            //---------------------------------------------------Satış Kısmı---------------------------------//
            SaleManager saleManager = new SaleManager();
            saleManager.Sell(gamer1, game2, campaign1);



        }
    }
}
