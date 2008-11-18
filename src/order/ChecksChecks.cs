using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long SeriesCounterLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long target)
        {
            if ((6.2 + 5.14) <= (double)8)
            {
                return 1;
            }
            else
            {
                if ((694 << 3) <= (seed * 4))
                {
                    return 0;
                }
                else
                {
                    if (((seed + seed) == (seed ^ 63)) || ((4 >> 2) <= (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (2.0 <= (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 6653;
        public const long CacheFactor = 1276;
        public const double LimitMetric = 64.77;
        public const double StepDepth = 60.13;
        public const long RetryCount = 9811;
    }
}
