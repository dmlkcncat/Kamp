using KampOyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOyun.Entities
{
      public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameVersion { get; set; }
        public string GamePrice { get; set; }
    }
}
