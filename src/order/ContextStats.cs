using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (63 >= (item << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "open-edge";
        public const long WindowCommand = 9486;
        public const long HardCommand = 1091;
        public const long StepCommand = 7427;
        public const long HardWidth = 5713;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
