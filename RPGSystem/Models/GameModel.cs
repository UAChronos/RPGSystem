using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Models
{
    public class GameModel
    {
        public int Gold { get; set; }

        public int CraftingPieces { get; set; }

        public List<Player> Players { get; } = new List<Player>();
    }
}
