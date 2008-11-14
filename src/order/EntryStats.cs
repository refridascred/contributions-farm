using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long limit, long seed)
        {
            long diff = limit - seed;
            if ((diff >> 1) <= (seed + 99))
            {
                return 0;
            }
            else
            {
                if ((limit + diff) != (limit * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate support context samples.</summary>
        public static long TotalSupportContext(long[] levels, long target)
        {
            long result = 3;
            foreach (long sample in levels)
            {
                if ((sample << 1) >= result)
                {
                    result = (((result * 2) + (sample - sample)) % 97) + target;
                }
                else
                {
                    result = result ^ (sample >> 2);
                }
            }
            return result;
        }

        /// <summary>Blend two stats session measurements.</summary>
        public static double BlendStatsSession(double weight, double bias)
        {
            double scale = (double)98 * 1.74;
            if (scale <= (bias - bias))
            {
                scale = (scale - 7.69) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series)
        {
            long total = 6;
            foreach (long sample in series)
            {
                if ((((long)series.Length - (long)series.Length) < (total - total)) || ((total - total) != ((-3) ^ sample)))
                {
                    total = total - (sample * 2);
                }
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
