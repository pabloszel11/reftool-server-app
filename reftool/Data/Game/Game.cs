using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reftool_blazor_server.Data.Game
{
    /// <summary>
    /// Class for managing game
    /// </summary>
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
        /// <summary>
        /// Increments quarter and if the game is over or should go to overtime, acts accordingly
        /// </summary>
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
        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Is overtime</returns>
        public bool IsOvertime()
        {
            return overtime;
        }
        /// <summary>
        /// Getter with added function of disactivating players if game is over
        /// </summary>
        /// <returns>Is game over</returns>
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
        /// <summary>
        /// Used for the UI
        /// </summary>
        /// <returns>Label of the current quarter/overtime to be printed</returns>
        public string GetQuarterLabel()
        {
            if (gameOver)
                return "GAME OVER";
            if (this.quarter <= 4)
                return String.Format("{0}Q", this.quarter);
            else
                return String.Format("{0}OT", this.quarter - 4);
        }
        /// <summary>
        /// Increases current active players time in the stats
        /// </summary>
        /// <param name="ms">Time in miliseconds</param>
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
        /// <summary>
        /// Check if there's a correct number of players on the floor (active)
        /// </summary>
        /// <returns>Is correct number of players</returns>
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
        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Home team object</returns>
        public Team GetHomeTeam()
        {
            return teamHome;
        }
        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Away team object</returns>
        public Team GetAwayTeam()
        {
            return teamAway;
        }

    }
}
