using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Final_ConnectFour
{
    public class Stats
    {
        private static string filePath = @"../../Resources/stats.json";
        public int ComputerWins { get; set; }
        public int PlayerWins { get; set; }
        public int Draws { get; set; }

        public Stats() 
        {
        }

        public Stats(int computerWins, int playerWins, int draws)
        {
            this.ComputerWins = computerWins;
            this.PlayerWins = playerWins;
            this.Draws = draws;
        }

        public void Populate()
        {
            Stats stats = JsonConvert.DeserializeObject<Stats>(File.ReadAllText(filePath));
            this.ComputerWins = stats.ComputerWins;
            this.PlayerWins = stats.PlayerWins;
            this.Draws = stats.Draws;
        }

        public void AddWin(int playerNumber)
        {
            if (playerNumber == 1) PlayerWins++;
            if (playerNumber == 2) ComputerWins++;
            string jsonString = JsonConvert.SerializeObject(this);
            File.WriteAllText(filePath, jsonString);
        }

        public void AddDraw()
        {
            Draws++;
            string jsonString = JsonConvert.SerializeObject(this);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
