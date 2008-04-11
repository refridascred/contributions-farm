using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a entry cache reading by value.</summary>
        public static long LocateEntryCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((matches << 1) == (item << 1)) || ((matches - item) >= (item * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two session metrics measurements.</summary>
        public static double SmoothSessionMetrics(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 < (ratio * 7.65))
            {
                ratio2 = (ratio2 + (double)877) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio2 * 14.0)) - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches + matches) < matches) || !((19.0 * 4.24) >= (3.0 * 3.0)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
