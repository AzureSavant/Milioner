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
    static class Helper
    {
        public static GameState LoadGameStateFromFile()
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

        public static void SaveGameStateToFile(GameState gameState)
        {
            var data = JsonConvert.SerializeObject(gameState);
            File.WriteAllText("../../gameState.json",data);
        }
    }
}
