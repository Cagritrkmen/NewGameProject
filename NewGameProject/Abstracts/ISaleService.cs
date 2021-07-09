using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject
{
    interface ISaleService
    {
        void Sell(Gamer gamer, Game game,Campaign campaign);
    }
}
