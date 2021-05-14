using System;
using System.Collections.Generic;
using System.Text;
using KampOyun.Entities;

namespace KampOyun.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " " + game.GameVersion + " için geçerli olan indirim bitmiştir!");
        }

        public void Register(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " " + game.GameVersion + " oyunu " + campaign.StartingDate + " tarihinden " + campaign.DueDate + " tarihine kadar " + campaign.CampaignValue + " indirimi ile satışa sunulmuştur!");
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " " + game.GameVersion + " oyunu indirimi " + campaign.CampaignValue + " olarak güncellenmiştir.");
        }
    }
}
