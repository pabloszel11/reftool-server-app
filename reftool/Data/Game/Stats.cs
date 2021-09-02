using Blazorise;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reftool_blazor_server.Data.Game
{
    /// <summary>
    /// General class for game stats
    /// </summary>
    public class Stats
    {
        public int Points, Rebounds, ORebounds, Assists, Steals, Turnovers, FGM, FGA, TPM, TPA, FTM, FTA, Blocks, Time, Fouls, OFouls, QuarterFouls;

        public Stats()
        {
            Points = 0;
            Rebounds = 0;
            ORebounds = 0;
            Assists = 0;
            Steals = 0;
            Turnovers = 0;
            FGM = 0;
            FGA = 0;
            TPM = 0;
            TPA = 0;
            FTM = 0;
            FTA = 0;
            Blocks = 0;
            Time = 0;
            Fouls = 0;
            OFouls = 0;
            QuarterFouls = 0;
        }
        /// <summary>
        /// Two point shot stat modifier
        /// </summary>
        /// <param name="made">Is the shot made</param>
        public void TwoPointer(bool made)
        {
            this.FGA++;
            if (made)
            {
                this.Points += 2;
                this.FGM++;
            }
        }
        /// <summary>
        /// Three point shot stat modifier
        /// </summary>
        /// <param name="made">Is the shot made</param>
        public void ThreePointer(bool made)
        {
            this.FGA++;
            this.TPA++;
            if (made)
            {
                this.Points += 3;
                this.FGM++;
                this.TPM++;
            }
        }
        /// <summary>
        /// Free throw stat modifier
        /// </summary>
        /// <param name="made">Is the shot made</param>
        public void FreeThrow(bool made)
        {
            this.FTA++;
            if(made)
            {
                this.Points++;
                this.FTM++;
            }
        }
        /// <summary>
        /// Rebound stat modifier
        /// </summary>
        /// <param name="off">Is offensive rebound</param>
        public void Rebound(bool off)
        {
            this.Rebounds++;
            if (off)
                this.ORebounds++;
        }
        /// <summary>
        /// Foul stat modifier
        /// </summary>
        /// <param name="offensive">Is offensive foul</param>
        public void Foul(bool offensive)
        {
            if (offensive)
                this.OFouls++;
            else
                this.QuarterFouls++;

            this.Fouls++;      
        }

        /// <summary>
        /// Assist stat modifier
        /// </summary>
        public void Assist()
        {
            this.Assists++;
        }
        /// <summary>
        /// Steal stat modifier
        /// </summary>
        public void Steal()
        {
            this.Steals++;
        }
        /// <summary>
        /// Turnover stat modifier
        /// </summary>
        public void Turnover()
        {
            this.Turnovers++;
        }
        /// <summary>
        /// Block stat modifier
        /// </summary>
        public void Block()
        {
            this.Blocks++; 
        }
        /// <summary>
        /// Resets teams' fouls for the quarter
        /// </summary>
        public void ResetQuarterFouls()
        {
            this.QuarterFouls = 0;
        }
        /// <summary>
        /// Checks if team is over foul limit
        /// </summary>
        /// <returns>Is team over foul limit</returns>
        public bool OverLimit()
        {
            return this.QuarterFouls >= 5;
        }


    }
    /// <summary>
    /// Class for player game stats
    /// </summary>
    public class PlayerStats : Stats
    {
        public Team PlayerTeam;

        public PlayerStats(Player p, Team t)
        {
            Points = 0;
            Rebounds = 0;
            Assists = 0;
            Steals = 0;
            Turnovers = 0;
            FGM = 0;
            FGA = 0;
            TPM = 0;
            TPA = 0;
            FTM = 0;
            FTA = 0;
            Blocks = 0;
            Fouls = 0;
            OFouls = 0;
            PlayerTeam = t;
        }
        /// <summary>
        /// Two point shot modifier
        /// </summary>
        /// <param name="made">Is shot made</param>
        public new void TwoPointer(bool made)
        {
            this.FGA++;
            if (made)
            {
                this.Points += 2;
                this.FGM++;
            }
            PlayerTeam.Stats.TwoPointer(made);
        }
        /// <summary>
        /// Three point shot modifier
        /// </summary>
        /// <param name="made">Is shot made</param>
        public new void ThreePointer(bool made)
        {
            this.FGA++;
            this.TPA++;
            if (made)
            {
                this.Points += 3;
                this.FGM++;
                this.TPM++;
            }
            PlayerTeam.Stats.ThreePointer(made);
        }
        /// <summary>
        /// Free throw shot modifier
        /// </summary>
        /// <param name="made">Is shot made</param>
        public new void FreeThrow(bool made)
        {
            this.FTA++;
            if (made)
            {
                this.Points++;
                this.FTM++;
            }
            PlayerTeam.Stats.FreeThrow(made);
        }
        /// <summary>
        /// Rebound stat modifier
        /// </summary>
        /// <param name="off">Is offensive rebound</param>
        public new void Rebound(bool off)
        {
            this.Rebounds++;
            if (off)
                this.ORebounds++;

            PlayerTeam.Stats.Rebound(off);
        }
        /// <summary>
        /// Foul stat modifier
        /// </summary>
        /// <param name="offensive">Is offensive foul</param>
        public new void Foul(bool offensive)
        {
            if (offensive)
                this.OFouls++;
            this.Fouls++;

            PlayerTeam.Stats.Foul(offensive);
        }
        /// <summary>
        /// Assist stat modifier
        /// </summary>
        public new void Assist()
        {
            this.Assists++;
            PlayerTeam.Stats.Assist();
        }
        /// <summary>
        /// Steal stat modifier
        /// </summary>
        public new void Steal()
        {
            this.Steals++;
            PlayerTeam.Stats.Steal();
        }
        /// <summary>
        /// Turnover stat modifier
        /// </summary>
        public new void Turnover()
        {
            this.Turnovers++;
            PlayerTeam.Stats.Turnover();
        }
        /// <summary>
        /// Block stat modifier
        /// </summary>
        public new void Block()
        {
            this.Blocks++;
            PlayerTeam.Stats.Block();
        }

        /// <summary>
        /// Increase time stat of a player by certain number on ms
        /// </summary>
        /// <param name="scale">Number of ms spent on the floor</param>
        public void IncTim(int scale)
        {
            this.Time += scale;
        }

        /// <summary>
        /// Get time in minutes
        /// </summary>
        /// <returns>Time spent on the floor in minutes</returns>
        public int TimeInMin()
        {
            return this.Time / 60000;
        }
        

    }

    
    /// <summary>
    /// Class for undo functionality
    /// </summary>
    public static class RevertStats
    {
        /// <summary>
        /// Revert two point shot modifier 
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        /// <param name="made">Was shot made</param>
        public static void TwoPointer(PlayerStats p, bool made)
        {
            p.FGA--;
            p.PlayerTeam.Stats.FGA--;
            if(made)
            {
                p.FGM--;
                p.PlayerTeam.Stats.FGM--;
                p.Points -= 2;
                p.PlayerTeam.Stats.Points -= 2;
            }
        }
        /// <summary>
        /// Revert three point shot modifier 
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        /// <param name="made">Was shot made</param>
        public static void ThreePointer(PlayerStats p, bool made)
        {
            p.FGA--;
            p.PlayerTeam.Stats.FGA--;
            if (made)
            {
                p.FGM--;
                p.PlayerTeam.Stats.FGM--;
                p.Points -= 3;
                p.PlayerTeam.Stats.Points -= 3;
            }
        }
        /// <summary>
        /// Revert free throw stat modifier 
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        /// <param name="made">Was shot made</param>
        public static void FreeThrow(PlayerStats p, bool made)
        {
            p.FGA--;
            p.PlayerTeam.Stats.FGA--;
            if (made)
            {
                p.FGM--;
                p.PlayerTeam.Stats.FGM--;
                p.Points--;
                p.PlayerTeam.Stats.Points--;
            }
        }
        /// <summary>
        /// Revert rebound stat modifier
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        /// <param name="off">Was shot made</param>
        public static void Rebound(PlayerStats p, bool off)
        {
            p.Rebounds--;
            p.PlayerTeam.Stats.Rebounds--;
            if (off)
            {
                p.ORebounds--;
                p.PlayerTeam.Stats.ORebounds--;
            }
        }
        /// <summary>
        /// Revert assist stat modifier
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        public static void Assist(PlayerStats p)
        {
            p.Assists--;
            p.PlayerTeam.Stats.Assists--;
        }
        /// <summary>
        /// Revert steal stat modifier
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        public static void Steal(PlayerStats p)
        {
            p.Steals--;
            p.PlayerTeam.Stats.Steals--;
        }
        /// <summary>
        /// Revert turnover stat modifier
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        public static void Turnover(PlayerStats p)
        {
            p.Turnovers--;
            p.PlayerTeam.Stats.Turnovers--;
        }
        /// <summary>
        /// Revert foul stat modifier
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        /// <param name="offensive">Was an offensive foul</param>
        public static void Foul(PlayerStats p, bool offensive)
        {
            if (offensive)
            {
                p.OFouls--;
                p.PlayerTeam.Stats.OFouls--;
            }
                
            p.Fouls--;
            p.PlayerTeam.Stats.Fouls--;
        }
        /// <summary>
        /// Revert turnover stat modifier
        /// </summary>
        /// <param name="p">Stats of a player to do modification on</param>
        public static void Block(PlayerStats p)
        {
            p.Blocks--;
            p.PlayerTeam.Stats.Blocks--;
        }
    }
}
