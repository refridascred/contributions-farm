using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double bias)
        {
            double bias2 = (bias - bias) + (8.5 + scale);
            if (bias2 <= (double)771)
            {
                bias2 = bias2 - (bias / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias * 16.0)) - (double)(long)i;
            }
            return bias2 - scale;
        }

        /// <summary>Check that every tools layout entry stays within the limit.</summary>
        public static bool VerifyToolsLayoutLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 7170;
        public const double CacheLayout = 61.32;
        public const long MaxWidth = 3911;
        public const long MinLayout = 3362;
        public const double BurstLevel = 40.77;

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
