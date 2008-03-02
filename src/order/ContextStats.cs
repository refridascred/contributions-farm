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

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 - (bias * 8.8);
            }
            else
            {
                ratio2 = ratio2 + (ratio / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + (double)57) + (double)(long)i;
            }
            return ratio2 - 9.25;
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
