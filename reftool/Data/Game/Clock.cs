using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.AspNetCore.Components;

namespace reftool_blazor_server.Data.Game
{
    /// <summary>
    /// Class representing game clock
    /// </summary>
    public class Clock
    {
        int gameTime;
        string printState = "Start";
        bool buttonState = false;
        TimeSpan t = TimeSpan.FromMilliseconds(10000);
        string printTime;
       


        public Clock()
        {
            this.gameTime = 600000;
            this.printTime = TimeSpan.FromMilliseconds(this.gameTime).ToString(@"mm\:ss\:f");
            this.printState = "Start";
            this.buttonState = false;
        }
        /// <summary>
        /// Decreases time by specific number of miliseconds
        /// </summary>
        /// <param name="ms">Number of miliseconds</param>
        public void DecTime(int ms)
        {
            if(this.gameTime > 0)
                this.gameTime -= ms;

            this.t = TimeSpan.FromMilliseconds(this.gameTime);
            this.printTime = this.t.ToString(@"mm\:ss\:f");
        }
        /// <summary>
        /// Increases time by specific number of miliseconds
        /// </summary>
        /// <param name="ms">Number of miliseconds</param>
        public void IncTime(int ms)
        {
            if (this.gameTime < 600000)
                this.gameTime += ms;

            this.t = TimeSpan.FromMilliseconds(this.gameTime);
            this.printTime = this.t.ToString(@"mm\:ss\:f");
        }
        /// <summary>
        /// Resets the clock to proper number of miliseconds based on the fact if it's overtime or not (10mins regular quarter, 5min overtime)
        /// </summary>
        /// <param name="overtime">Is overtime</param>
        public void ResetClock(bool overtime)
        {
            if (overtime)
                this.gameTime = 300000;
            else
                this.gameTime = 600000;
        }
        /// <summary>
        /// Sets the state and the label on the button based on the fact if it's pressed
        /// </summary>
        /// <param name="pressed">Is button pressed</param>
        public void SetButton(bool pressed)
        {
            if (pressed)
                this.printState = "Stop";
            else
                this.printState = "Start";

            this.buttonState = pressed;
        }
        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Current game time</returns>
        public int GetGameTime()
        {
            return gameTime;
        }
        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Current game time to be printed in the UI</returns>
        public string GetPrintTime()
        {
            return this.printTime;
        }
        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Current label on the button</returns>
        public string GetPrintState()
        {
            return this.printState;
        }
        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Is button pressed</returns>
        public bool IsButtonPressed()
        {
            return this.buttonState;
        }

    }
}
