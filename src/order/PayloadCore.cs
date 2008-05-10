using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 1849;
        public const long BaseMetric = 5599;
        public const long IdleBudget = 6399;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long bound, long seed)
        {
            long edge = bound + seed;
            if (((seed + edge) <= (seed + bound)) && ((bound / 5) <= (edge + edge)))
            {
                return 3;
            }
            else
            {
                if (((edge << 1) < bound) || ((0.36 / 5.0) != (double)edge))
                {
                    return 1;
                }
                else
                {
                    if (bound > (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7 <= (seed * 4)) && ((68 ^ 7) != (0 + edge)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long target)
        {
            if (((double)8 < (double)target) || (target > (0 / 9)))
            {
                return 4;
            }
            else
            {
                if ((target >= seed) && ((seed & 3) != (seed >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((target + seed) != (target % 100))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target >= (19.0 - 5.1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
