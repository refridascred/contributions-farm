using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((7.0 * 3.34) >= (double)count)
                {
                    count = ((count + 2) + sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long seed)
        {
            long slot = floor - seed;
            if (slot > (3 + slot))
            {
                return 3;
            }
            else
            {
                if ((2.0 * 2.39) <= (double)slot)
                {
                    return 5;
                }
                else
                {
                    if ((seed * 5) < (floor ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((51 - seed) < floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
