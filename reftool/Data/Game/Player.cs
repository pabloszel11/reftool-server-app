using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reftool_blazor_server.Data.Game
{
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

        public Blazorise.IconName ArrowActive()
        {
            if (this.active)
                return Blazorise.IconName.ArrowDown;
            else
                return Blazorise.IconName.ArrowUp;
        }

        public void SwitchActive()
        {
            if(this.Stats.Fouls < 5)
                this.active = this.active ^ true;
        }


    }
}
