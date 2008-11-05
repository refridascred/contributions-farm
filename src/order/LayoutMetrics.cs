using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the channel order entries that pass the check.</summary>
        public static long CountChannelOrderHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((step / 4) >= seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the command cache entries that pass the check.</summary>
        public static long CountCommandCacheOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((floor / 7) > (matches - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - value) > seen)
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
