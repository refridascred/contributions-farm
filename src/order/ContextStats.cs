using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)target == (double)66)
                {
                    mix = (mix ^ (mix ^ (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long CountTokenMetricHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (offset < (item % 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item << 1) >= item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Locked,
            Pending,
            Retry,
            Stale,
        }
    }
}
