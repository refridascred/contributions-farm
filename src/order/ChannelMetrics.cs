using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long floor)
        {
            long slot = seed - floor;
            if ((seed >> 4) < (floor / 4))
            {
                return 8;
            }
            else
            {
                if (((slot ^ seed) < (seed - floor)) || ((9.07 * 6.8) <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long IterateMetricsTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + bound) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry << 2) == (entry - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
