using KampOyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOyun.Abstract
{
    public interface ICampaignService
    {
        void Register(Game game, Campaign campaign);
        void Update(Game game, Campaign campaign);
        void Delete(Game game, Campaign campaign);
    }
}
