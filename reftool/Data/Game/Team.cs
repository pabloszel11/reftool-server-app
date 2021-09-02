using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reftool_blazor_server.Data.Game
{
    /// <summary>
    /// Class for team in game
    /// </summary>
    public class Team
    {
        public string Name;
        public List<Player> Players;
        public Stats Stats;

        public Team(string name, List<Player> players)
        {
            Name = name;
            Players = players;
            Stats = new Stats();
        }
    }
}
