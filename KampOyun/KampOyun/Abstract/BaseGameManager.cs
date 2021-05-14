using System;
using System.Collections.Generic;
using System.Text;
using KampOyun.Entities;

namespace KampOyun.Abstract
{
    public abstract class BaseGameManager : IGameService
    {
        public void GameBuy(Game game, Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " tarafından " + game.GameName + " " + game.GameVersion + " sürümü " + game.GamePrice + " tl fiyatına satın alınmıştır.");
        }

        public void GameSell(Game game, Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " tarafından " + game.GameName + " " + game.GameVersion + " sürümü " + game.GamePrice + " tl fiyatına satılmıştır.");
        }
    }
}
