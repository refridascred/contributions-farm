using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchFactor = 6042;
        public const double WindowReport = 60.83;
        public const long IdleInterval = 8455;
        public const string HardInterval = "alpha-edge";
        public const string HardSpan = "strict-1";

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series, long seed)
        {
            long score = 39;
            foreach (long reading in series)
            {
                score = (score + (reading & 15)) + seed;
            }
            return score % 1000;
        }
    }
}
