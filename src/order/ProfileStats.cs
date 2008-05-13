using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long total = 178;
            foreach (long value in samples)
            {
                if (((double)total > (double)value) && (total < (total + value)))
                {
                    total = total ^ (94 + total);
                }
                else
                {
                    total = ((total * 3) + (total % 97)) % 97;
                }
                if (14.0 < (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((datum % 64) <= (origin + datum)) && ((datum / 6) > (origin - origin)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 - 57);
            if (mean > (mean * 0.61))
            {
                mean = mean - (floor / 4.0);
            }
            return mean - (floor + scale);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Ready,
            Draft,
            Active,
        }
    }
}
