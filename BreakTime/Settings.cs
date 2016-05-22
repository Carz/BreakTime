using System;
using System.IO;
using Styx;
using Styx.Common;
using Styx.Helpers;

namespace BreakTime
{
    class PlugSettings : Settings
    {
        public static readonly PlugSettings Instance = new PlugSettings();
        public PlugSettings()
            :base(Path.Combine(Utilities.AssemblyDirectory, string.Format(@"Plugins/BreakTime/Settings/BreakTimeSettings-{0}.xml", StyxWoW.Me.Name)))
        {

        }
        [Setting, DefaultValue(mode.defaultMode)]
        public mode usedMode { get; set; }
        [Setting, DefaultValue(3)]
        public int minBreakTime { get; set; }
        [Setting, DefaultValue(7)]
        public int maxBreakTime { get; set; }
        [Setting, DefaultValue(45)]
        public int minBetweenTime { get; set; }
        [Setting, DefaultValue(90)]
        public int maxBetweenTime { get; set; }
    }
}
