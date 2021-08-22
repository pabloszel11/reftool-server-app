using Blazorise;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reftool_blazor_server.Data.Game
{
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

        public void TwoPointer(bool made)
        {
            this.FGA++;
            if (made)
            {
                this.Points += 2;
                this.FGM++;
            }
        }
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
        public void FreeThrow(bool made)
        {
            this.FTA++;
            if(made)
            {
                this.Points++;
                this.FTM++;
            }
        }
        public void Rebound(bool off)
        {
            this.Rebounds++;
            if (off)
                this.ORebounds++;
        }
        public void Assist()
        {
            this.Assists++;
        }
        public void Steal()
        {
            this.Steals++;
        }
        public void Turnover()
        {
            this.Turnovers++;
        }
        public void Foul(bool offensive)
        {
            if (offensive)
                this.OFouls++;
            else
                this.QuarterFouls++;

            this.Fouls++;
            
        }
        public void Block()
        {
            this.Blocks++; 
        }

        public void ResetQuarterFouls()
        {
            this.QuarterFouls = 0;
        }

        public bool OverLimit()
        {
            return this.QuarterFouls >= 5;
        }


    }

    public class PlayerStats : Stats
    {
        public double Eval;
        public int PlusMinus;
        [Inject] INotificationService NotificationService { get; set; }
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
        public new void Rebound(bool off)
        {
            this.Rebounds++;
            if (off)
                this.ORebounds++;

            PlayerTeam.Stats.Rebound(off);
        }
        public new void Assist()
        {
            this.Assists++;
            PlayerTeam.Stats.Assist();
        }
        public new void Steal()
        {
            this.Steals++;
            PlayerTeam.Stats.Steal();
        }
        public new void Turnover()
        {
            this.Turnovers++;
            PlayerTeam.Stats.Turnover();
        }
        public new void Block()
        {
            this.Blocks++;
            PlayerTeam.Stats.Block();
        }
        public void IncTim(int scale)
        {
            this.Time += scale;
        }
        public int TimeInMin()
        {
            return this.Time / 60000;
        }
        public new void Foul(bool offensive)
        {
            if (offensive)
                this.OFouls++;
            this.Fouls++;

            PlayerTeam.Stats.Foul(offensive);
        }

    }

    public static class RevertStats
    {
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
        public static void Assist(PlayerStats p)
        {
            p.Assists--;
            p.PlayerTeam.Stats.Assists--;
        }
        public static void Steal(PlayerStats p)
        {
            p.Steals--;
            p.PlayerTeam.Stats.Steals--;
        }
        public static void Turnover(PlayerStats p)
        {
            p.Turnovers--;
            p.PlayerTeam.Stats.Turnovers--;
        }
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
        public static void Block(PlayerStats p)
        {
            p.Blocks--;
            p.PlayerTeam.Stats.Blocks--;
        }
    }
}
