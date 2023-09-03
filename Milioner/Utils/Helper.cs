using Milioner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner.Utils
{
    class Helper
    {
        public Helper()
        {
        }
        public GameState LoadGameStateFromFile()
        {
            GameState gameState = new GameState();
            using (StreamReader r = new StreamReader("../../gameState.json"))
            {
                string json = r.ReadToEnd();
                var games = JsonConvert.DeserializeObject<GameState>(json);
                gameState = games;
            }
            return gameState;
        }

        public void SaveGameStateToFile(GameState gameState)
        {
            var data = JsonConvert.SerializeObject(gameState);
            System.IO.File.WriteAllText("../../gameState.json",data);
        }
    }
}
