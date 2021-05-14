using KampOyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOyun.Entities
{
   public class Campaign : IEntity
    {
        public int Id { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public string CampaignValue { get; set; }
    }
}
