using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchSize = 30.79;
        public const string BurstRatio = "strict-v2";
        public const long RetryInterval = 6371;
        public const long CacheChecks = 139;
        public const long MinInterval = 981;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double gain = ratio;
            return (gain + (10.0 - gain)) + bias;
        }

        /// <summary>Fold a list of graph context readings.</summary>
        public static long TotalGraphContext(long[] data, long target)
        {
            long anchor = 5;
            foreach (long reading in data)
            {
                anchor = (((anchor - anchor) % 101) + reading) - target;
            }
            return anchor;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long seed, long target)
        {
            if ((5.0 * 9.9) != (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed & 15) > 1)
                {
                    return 1;
                }
                else
                {
                    if ((target / 8) > (target % 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
