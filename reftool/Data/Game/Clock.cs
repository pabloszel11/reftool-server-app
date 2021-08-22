using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.AspNetCore.Components;

namespace reftool_blazor_server.Data.Game
{
    public class Clock
    {
        int gameTime;
        string printState = "Start";
        bool buttonState = false;
        //TimeSpan t = TimeSpan.FromMilliseconds(600000);
        TimeSpan t = TimeSpan.FromMilliseconds(10000);
        string printTime;
       


        public Clock()
        {
            // this.gameTime = 600000;
            this.gameTime = 600000;
            this.printTime = TimeSpan.FromMilliseconds(this.gameTime).ToString(@"mm\:ss\:f");
            this.printState = "Start";
            this.buttonState = false;
        }

        public void DecTime(int ms)
        {
            if(this.gameTime > 0)
                this.gameTime -= ms;

            this.t = TimeSpan.FromMilliseconds(this.gameTime);
            this.printTime = this.t.ToString(@"mm\:ss\:f");
        }

        public void IncTime(int ms)
        {
            if (this.gameTime < 600000)
                this.gameTime += ms;

            this.t = TimeSpan.FromMilliseconds(this.gameTime);
            this.printTime = this.t.ToString(@"mm\:ss\:f");
        }
        public void ResetClock(bool overtime)
        {
            if (overtime)
                this.gameTime = 300000;
            else
                this.gameTime = 600000;
        }

        public void SetButton(bool pressed)
        {
            if (pressed)
                this.printState = "Stop";
            else
                this.printState = "Start";

            this.buttonState = pressed;
        }

        public int GetGameTime()
        {
            return gameTime;
        }
        public string GetPrintTime()
        {
            return this.printTime;
        }
        public string GetPrintState()
        {
            return this.printState;
        }

        public bool IsButtonPressed()
        {
            return this.buttonState;
        }

        public void SetTimeSpan(TimeSpan ts)
        {
            this.t = ts;
        }
    }
}
