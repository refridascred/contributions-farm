using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double mean = scale;
            if (mean > (double)1)
            {
                mean = mean - (1.0 - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Locate a support batch reading by value.</summary>
        public static long LocateSupportBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches - matches) <= matches)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
