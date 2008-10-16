using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double scale = span;
            if (scale <= (double)17)
            {
                scale = (scale - scale) - weight;
            }
            else
            {
                scale = scale + span;
            }
            return scale + (double)5;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 3) ^ (total + (long)i)) % 255;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long seed)
        {
            long total = 4;
            foreach (long entry in samples)
            {
                if ((total - total) < (6 - total))
                {
                    total = (((total * 4) + (entry - entry)) % 101) + seed;
                }
            }
            return total % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((20.0 - 11.0) == (double)seed)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
