using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + 2) > (reading / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster entry reading by value.</summary>
        public static long SeekClusterEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long seed)
        {
            long acc = 46;
            foreach (long reading in series)
            {
                acc = ((acc ^ reading) % 1000) - seed;
            }
            return acc % 1000;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long origin, long seed)
        {
            long gap = origin + seed;
            if ((seed - gap) >= (gap + gap))
            {
                return 0;
            }
            else
            {
                if ((seed >= (seed - origin)) || ((double)gap >= (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
