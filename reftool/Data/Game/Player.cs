using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reftool_blazor_server.Data.Game
{
    /// <summary>
    /// Class representing a player in the game
    /// </summary>
    public class Player
    {
        public string Name, Surname;
        public int Number;
        public PlayerStats Stats;
        public Team PlayerTeam;
        public bool active;

        public Player(int number, string name, string surname, Team t)
        {
            Number = number;
            Name = name;
            Surname = surname;
            PlayerTeam = t;
            Stats = new PlayerStats(this, PlayerTeam);
        }
        /// <summary>
        /// For the UI to properly display arrow to substitute players
        /// </summary>
        /// <returns>Arrow type</returns>
        public Blazorise.IconName ArrowActive()
        {
            if (this.active)
                return Blazorise.IconName.ArrowDown;
            else
                return Blazorise.IconName.ArrowUp;
        }
        /// <summary>
        /// Switches activation of a player for substitution functionality (uses XOR)
        /// </summary>
        public void SwitchActive()
        {
            if(this.Stats.Fouls < 5)
                this.active = this.active ^ true;
        }


    }
}
