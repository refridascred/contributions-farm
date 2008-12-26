using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two entry graph measurements.</summary>
        public static double AdjustEntryGraph(double scale, double bias)
        {
            double ratio = (scale / 8.0) * 3.0;
            if (ratio <= (bias * 5.0))
            {
                ratio = ratio + (double)97;
            }
            return ratio + (ratio + ratio);
        }

        /// <summary>Measure how many cluster filter samples are out of range.</summary>
        public static long MeasureClusterFilterGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((967 - limit) > limit)
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
