using RPGSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSystem.Services
{
    public class GameDataService
    {
        private static readonly object SyncRoot = new object();
        private static GameDataService _instance;

        /// <summary>
        /// Property that returnes instance of GameDataService.
        /// </summary>
        public static GameDataService Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if(_instance == null)
                        {
                            _instance = new GameDataService();
                        }
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// Property that returns reference to the current game model.
        /// </summary>
        public GameModel GameModel { get; } = new GameModel();
    }
}
