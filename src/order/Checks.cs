using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support layout samples are out of range.</summary>
        public static long CountSupportLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((4 - item) >= (hits ^ 41))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (sum + sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long acc = -639;
            foreach (long datum in samples)
            {
                if ((datum + 8) != (datum * 3))
                {
                    acc = (acc ^ (261 & 31)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool ValidateCacheProfileBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
