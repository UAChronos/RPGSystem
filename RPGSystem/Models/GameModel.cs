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
        /// Property that returns ammount of crafting pieces.
        /// </summary>
        public int CraftingPieces { get; set; }
        /// <summary>
        /// Property that returns list of players.
        /// </summary>
        public List<Player> Players { get; internal set;} = new List<Player>();

        /// <summary>
        /// Creates a new player with defaults
        /// </summary>
        /// <returns>Newly created player</returns>
        public Player CreateNewPlayer()
        {
            var player = new Player()
            {
                Name = $"Player{Players.Count + 1}",
                Class = "No Class",
                Items = "No Items",
                Skills = "No Skills"
            };

            Players.Add(player);

            return player;
        }
    }
}
