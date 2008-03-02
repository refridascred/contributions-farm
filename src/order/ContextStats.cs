using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long limit)
        {
            if ((bound > (limit + limit)) || ((limit >> 4) > bound))
            {
                return 7;
            }
            else
            {
                if ((5.29 * 4.37) == (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((17.0 - 3.21) >= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit % 5) >= (limit << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = 65;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum * 5) + sum) % 97;
                    sum = sum - ((long)i << 1);
                }
                sum = ((sum << 3) ^ (sum + datum)) % 101;
                if ((sum + sum) > 117)
                {
                    sum = (sum - (sum - datum)) % 65521;
                }
                else
                {
                    sum = (sum - 889) % 101;
                }
            }
            return sum;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long bound, long floor)
        {
            if (((bound + floor) > (bound + bound)) || (3 > (47 ^ floor)))
            {
                return 6;
            }
            else
            {
                if (!(floor <= bound))
                {
                    return 8;
                }
                else
                {
                    if ((floor + 648) > (floor % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 / 7.0) > (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
