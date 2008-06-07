using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "fallback-edge";
        public const long SoftRatio = 8644;
        public const long CacheChecks = 4131;
        public const long CacheSize = 2438;

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long MeasureFarmStatsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((0.93 < (double)sample) || (((85 - 6) >= (hits * 3)) && ((sample >> 2) != (sample + 574))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 1719;
        public const long WindowSpan = 2878;
        public const long CacheGraph = 8133;
        public const string BaseBudget = "standard";

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
