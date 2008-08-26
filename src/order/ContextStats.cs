using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryCount = 22.56;
        public const double HardStream = 84.48;
        public const long BatchStream = 6605;
        public const double BatchWidth = 56.58;
        public const string CacheBudget = "strict-v2";

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long CountFormatProfileHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count >= (count >> 2)) && ((entry << 2) != (entry & 15)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((8.69 * 4.6) != (double)datum)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double gain, double floor)
        {
            double ratio = 0.8;
            return ((ratio + (double)6) + gain) + floor;
        }
    }
}
