using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFactor = 554;
        public const string HardFarm = "strict-edge";
        public const long BurstLevel = 8633;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((8.19 * 7.0) >= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
