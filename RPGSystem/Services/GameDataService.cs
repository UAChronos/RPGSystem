using Newtonsoft.Json;
using RPGSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
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
        public GameModel GameModel { get; private set; } = new GameModel();

        /// <summary>
        /// Method that saves current game data to xml file.
        /// </summary>
        /// <param name="fileName">Location in which file will be saved.</param>
        public void SaveToXml(string fileName)
        {
            using (var fileStream = File.OpenWrite(fileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameModel));
                xmlSerializer.Serialize(fileStream, GameModel);
            }
        }

        /// <summary>
        /// Method that opens and loads game data storaged as xml file.
        /// </summary>
        /// <param name="filePath">Location where file storaged.</param>
        public void LoadFromXml(string filePath)
        {
            using (var fileStream = File.OpenRead(filePath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameModel));
                GameModel = (GameModel)xmlSerializer.Deserialize(fileStream);
            }
        }

        /// <summary>
        /// Method that saves current game data to json file.
        /// </summary>
        /// <param name="fileName">Location in which file will be saved.</param>
        public void SaveToJson(string fileName)
        {
            using (StreamWriter streamWriter = File.CreateText(fileName))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(streamWriter, GameModel);
            }
        }

        /// <summary>
        /// Method that opens and loads game data storaged as json file.
        /// </summary>
        /// <param name="filePath">Location where file storaged.</param>
        public void LoadFromJson(string filePath)
        {
            using (StreamReader streamReader = File.OpenText(filePath))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                GameModel = JsonConvert.DeserializeObject<GameModel>(filePath);
            }
        }
    }
}
