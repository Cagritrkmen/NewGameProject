using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun EKlendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi");
        }
    }
}
