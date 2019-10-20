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

        public GameModel GameModel { get; } = new GameModel();
    }
}
