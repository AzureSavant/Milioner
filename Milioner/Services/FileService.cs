using Milioner.Models;
using Newtonsoft.Json;
using System.IO;

namespace Milioner.Utils
{
    static class FileService
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
