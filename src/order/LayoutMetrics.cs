using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 787;
        public const string CacheWindow = "primary-v2";
        public const long DefaultInterval = 1160;
        public const double BurstWindow = 35.95;
        public const long DefaultWindow = 6132;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((double)hits < (6.4 + 18.0)) && ((datum >> 3) == (hits + hits))) && (datum < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
