using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Models
{
    public class GameModel
    {
        /// <summary>
        /// Property that returns ammount of gold in current game.
        /// </summary>
        public int Gold { get; set; }
        /// <summary>
        /// Property that returns ammount crafting pieces.
        /// </summary>
        public int CraftingPieces { get; set; }
        /// <summary>
        /// Property that returns list of players.
        /// </summary>
        public List<Player> Players { get; } = new List<Player>();
    }
}
