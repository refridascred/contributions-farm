using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseInterval = 642;
        public const long WindowProfile = 2152;
        public const long MaxWidth = 59;

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double rate = scale;
            if (rate >= (offset * 15.0))
            {
                rate = rate - (scale + rate);
            }
            return rate + (scale + offset);
        }

        /// <summary>Locate a cluster token reading by value.</summary>
        public static long FindClusterTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long origin)
        {
            long offset = target - origin;
            if (origin >= (offset << 2))
            {
                return 6;
            }
            else
            {
                if ((origin ^ 5) < (origin & 31))
                {
                    return 8;
                }
                else
                {
                    if (((target >> 1) < target) || ((703 << 3) > target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
