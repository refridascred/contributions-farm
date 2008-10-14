using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = mean - (scale / 2.0);
            }
            return mean - mean;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double ratio = (scale - span) - span;
            if (ratio > (span + span))
            {
                ratio = ratio - (8.36 - scale);
            }
            else
            {
                ratio = ratio - (double)0;
            }
            return ratio + scale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum - hits) != (floor - datum)) || ((floor - floor) != (datum / 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
