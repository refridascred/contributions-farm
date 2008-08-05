using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((origin + origin) < origin)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
