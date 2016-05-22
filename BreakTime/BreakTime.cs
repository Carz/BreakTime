/*------------------------------------------------------------------------------------------------------------------------------------
 *      Plugin by:           Carz
 *      Version:            .007 Aphpla testing
 *      Note :              This is a plugin For HonorBuddy.
 *      
 * -----------------------------------------------------------------------------------------------------------------------------------*/
/// <Chanelog>
/// .001-.005  Code clean up
/// .006  Attempt to get save buttoppn to close ( No luck )
/// .007  Attempt to get save buttoppn to closex2 ( Suscessful)
/// .008  Code Clean up
/// .009  Change Thread.sleep to awit with help from Echo
/// .010  Add Some Styx
/// .011  Code Clean up with help from Echo
///	.012  Test Build for Aphla 
/// </Changelog>
using Buddy.Coroutines;
using System;
using System.Threading;
using System.Threading.Tasks;
using Styx.TreeSharp;
using Styx;
using Styx.Plugins;
using Styx.Common;
using Styx.CommonBot;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Styx.CommonBot.Coroutines;
using static System.Math;


namespace BreakTime
{
    public enum mode { defaultMode, questMode, petBattleMode, bgMode };                                                // Modes that can be used
    public class BreakTime : HBPlugin
    {
        #region Vars
        public mode usedMode;
        public int minBreakTime;                                                                // Minimum time to wait in minutes
        public int maxBreakTime;                                                                // Maximum time to wait in minutes
        public int minBetweenTime;                                                              // Minimum time to bot
        public int maxBetweenTime;                                                              // Maximum time to bot
        public static bool isBreaking = false;                                                  // Are we taking a break?!
        public static int logTimer = 10;                                                         // Minutes till we post the next log into HB!
        public static int waitTime = 0;                                                         // Time we will wait based on min & maxBreaktime
        public static int realBreakTime = 0;
        public static DateTime bottingStartTime, breakStartTime;
        public static double nextLog = 0;
        public static double emergLog = 0;
        Random rnd = new Random();
        #endregion Vars

        #region Overrides
        public override string Name { get { return "BreakTime"; } }
        public override string Author { get { return "Carz"; } }
        public override bool WantButton { get { return true; } }
        public override Version Version { get { return new Version(0, 0, 0, 8); } }                     //Aphla Testing
        public override string ButtonText { get { return "Settings"; } }


        
        public override void OnButtonPress()
        { 
            new Gui().ShowDialog(); 
        }
        public override void OnEnable()
        {
            PlugSettings.Instance.Load();
            BotEvents.OnBotStarted += OnBotStartHandler;
            BotEvents.OnBotStopped += OnBotStopHandler;
            Log("Enabled!");
        }
        public override void OnDisable()
        {
            BotEvents.OnBotStarted -= OnBotStartHandler;
            BotEvents.OnBotStopped -= OnBotStopHandler;
            Log("Disabled!");
        }
        public override void Pulse()
        {
            if(waitTime == 0)
            {
                bottingStartTime = DateTime.Now;
                nextLog = 0;
                emergLog = 0;
                waitTime = ranNum(minBetweenTime, maxBetweenTime);
            }
            switch(usedMode)
            {
                case mode.bgMode:
                    if (!isBreaking && ((DateTime.Now - bottingStartTime).TotalMinutes >= waitTime) && !Battlegrounds.IsInsideBattleground)
                    {
                        breakTaker();
                    }
                    break;
                case mode.petBattleMode:
                    if (!isBreaking && ((DateTime.Now - bottingStartTime).TotalMinutes >= waitTime) && !inPetCombat())
                    {
                        breakTaker();
                    }
                    break;
                //Only takes break if we are nearby to a Questgiver and we want to turn in a quest!
                case mode.questMode:
                    if (!isBreaking && ((DateTime.Now - bottingStartTime).TotalMinutes >= waitTime) && Me.CurrentTarget.QuestGiverStatus == QuestGiverStatus.TurnIn && Me.CurrentTarget.WithinInteractRange)
                    {
                        breakTaker();
                    }
                    break;
                //As usual. Takes break everywhere!
                case mode.defaultMode:
                    if (!isBreaking && ((DateTime.Now - bottingStartTime).TotalMinutes >= waitTime))
                    {
                        breakTaker();
                    }
                    break;
               
            }
            if ((logTimer != -1) && (((DateTime.Now - bottingStartTime).TotalMinutes) >= nextLog))
                nextLogOutput();
        }
        #endregion Overrides

        #region Functions
        public static LocalPlayer Me { get { return StyxWoW.Me; } }
        private mode selectedMode
        {
            get
            {
                PlugSettings.Instance.Load();
                return PlugSettings.Instance.usedMode;
            }
        }
        private void Log(string text, params object[] args)
        {
            Logging.Write("[BreakTime]: " + text, args);
        }

     public async Task<bool> breakTaker()
		{
   			await CommonCoroutines.StopMoving();
   			isBreaking = true;
   			Log("Break Starting!");
    		realBreakTime = (int)Math.Round(ranNumWithDecimal(minBreakTime, maxBreakTime), 2);
    		Log(string.Format($"Taking break for {realBreakTime.ToString()} minutes. Will resume around {DateTime.Now.AddMinutes(realBreakTime).ToShortTimeString()}."));
    		await Coroutine.Sleep(TimeSpan.FromMinutes(realBreakTime));
   			Log("Break is over. Now what was I doing? I remember!");
   			waitTime = 0;
    		isBreaking = false;
   				 return true;
		}
        public bool inPetCombat()
        {
            List<string> cnt = Lua.GetReturnValues("dummy,reason=C_PetBattles.IsTrapAvailable() return dummy,reason");

            if (cnt != null) { if (cnt[1] != "0") return true; }
            return false;
        }
        public void nextLogOutput()
        {
            Log(string.Format("{0} minutes until next break at {1}.", Math.Round((waitTime - (DateTime.Now - bottingStartTime).TotalMinutes), 2).ToString(), DateTime.Now.AddMinutes(waitTime).ToShortTimeString()));
            nextLog = (DateTime.Now - bottingStartTime).TotalMinutes + logTimer;
        }
        public int ranNum(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }
        public double ranNumWithDecimal(int min, int max)
        {
            double a = rnd.Next(min, max + 1);
            if (!(a >= max))
                a += rnd.NextDouble();
            while (a > max)
                a -= 0.1;
            while (a < min)
                a += 0.1;
            return a;
        }
        public void resetMe()
        {
            isBreaking = false;
            waitTime = 0;
            Log("Reset Done!");
        }
    
        #endregion Functions

        #region HB
        public void OnBotStartHandler(EventArgs args)
        {
            PlugSettings.Instance.Load();
            usedMode = selectedMode;
            minBreakTime = PlugSettings.Instance.minBreakTime;
            maxBreakTime = PlugSettings.Instance.maxBreakTime;
            minBetweenTime = PlugSettings.Instance.minBetweenTime;
            maxBetweenTime = PlugSettings.Instance.maxBetweenTime; 
            Log("Started!");
            resetMe();
            Log(usedMode.ToString("G"));
            
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            PlugSettings.Instance.Save();
        }

        public void OnBotStopHandler(EventArgs args)
        {
            Log("Stopped!");
            resetMe();
        }
        #endregion HB

    }
}
