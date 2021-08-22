using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reftool_blazor_server.Data.Game
{
    public class Game
    {
        public Clock clock;
        Team teamHome, teamAway;
        int quarter;
        bool overtime;
        bool gameOver;

        public Game() { }
        public Game(Team t1, Team t2)
        {
            teamHome = t1;
            teamAway = t2;
            overtime = false;
            gameOver = false;
            clock = new Clock();
            quarter = 1;
        }

        public void incQuarter()
        {
            quarter += 1;
            overtime = quarter > 4;
            if (overtime && teamHome.Stats.Points != teamAway.Stats.Points)
                gameOver = true;
            if(!overtime)
            {
                teamHome.Stats.ResetQuarterFouls();
                teamAway.Stats.ResetQuarterFouls();
            }
            
        }

        public bool IsOvertime()
        {
            return overtime;
        }

        public bool IsOver()
        {
            if(gameOver)
            {
                foreach (var p in teamHome.Players)
                    p.active = false;
                foreach (var p in teamAway.Players)
                    p.active = false;
            }
            return gameOver;
        }

        public string GetQuarterLabel()
        {
            if (gameOver)
                return "GAME OVER";
            if (this.quarter <= 4)
                return String.Format("{0}Q", this.quarter);
            else
                return String.Format("{0}OT", this.quarter - 4);
        }

        public void IncActPlayersTime(int ms)
        {
            foreach(Player p in this.teamHome.Players)
            {
                if(p.active)
                    p.Stats.IncTim(ms);
            }
            foreach (Player p in this.teamAway.Players)
            {
                if(p.active)
                    p.Stats.IncTim(ms);
            }
        }

        public bool RightAmountOfPlayers()
        {
            int counter1 = 0,
                counter2 = 0;
            foreach (Player p in this.teamHome.Players)
            {
                if (p.active)
                    counter1++;
            }
            foreach (Player p in this.teamAway.Players)
            {
                if (p.active)
                    counter2++;
            }

            return counter1 == 5 && counter2 == 5;
        }

        public Team GetHomeTeam()
        {
            return teamHome;
        }

        public Team GetAwayTeam()
        {
            return teamAway;
        }

    }
}
