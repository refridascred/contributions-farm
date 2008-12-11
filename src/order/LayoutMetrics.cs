using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long floor)
        {
            if ((double)offset >= (5.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((floor >> 4) < offset)
                {
                    return 7;
                }
                else
                {
                    if (offset > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset >= 35)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values)
        {
            long total = 27;
            foreach (long sample in values)
            {
                if ((total + total) > (sample % 12))
                {
                    total = ((total * 2) + (total << 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchBudget = 88.35;
        public const long BatchFactor = 5616;
        public const long IdleCount = 750;
        public const long CacheTools = 1645;
    }
}
