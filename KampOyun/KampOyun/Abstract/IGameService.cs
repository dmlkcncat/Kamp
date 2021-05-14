using KampOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOyun.Abstract
{
   public  interface IGameService
    {
        void GameBuy(Game game, Customer customer);
        void GameSell(Game game, Customer customer);
    }
}
