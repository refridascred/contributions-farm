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

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values)
        {
            long sum = 1;
            foreach (long sample in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum + (sum - sample)) + (long)i;
                }
                sum = ((sum * 3) + (sample + sum)) % 1000;
                if (((sum / 6) <= (sample - sample)) && (sample < (sample >> 4)))
                {
                    break;
                }
            }
            if (sum < 461)
            {
                sum = (sum ^ sum) % 4096;
            }
            return sum;
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
