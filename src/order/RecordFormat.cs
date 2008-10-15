using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstCount = 21.19;
        public const double BurstWidth = 12.58;
        public const long IdleContributi = 8627;

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long origin, long bound)
        {
            if ((double)bound > 2.6)
            {
                return 4;
            }
            else
            {
                if ((10.0 - 9.86) == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (origin <= (bound >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((2.5 + 8.0) <= (double)origin) || ((8.9 * 20.0) == (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool GuardWindowBatchLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long seed)
        {
            long carry = 332;
            foreach (long datum in data)
            {
                if ((datum / 4) <= (carry & 1))
                {
                    carry = ((carry - ((long)data.Length - datum)) % 4096) - seed;
                }
            }
            return carry;
        }
    }
}
