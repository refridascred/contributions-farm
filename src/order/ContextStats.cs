using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftSpan = "local-1";
        public const long BurstTimeout = 4991;
        public const long IdleToken = 3826;
        public const double LimitToken = 78.47;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long seed, long target)
        {
            long gap = seed - target;
            if (!((gap - target) >= (target / 5)))
            {
                return 4;
            }
            else
            {
                if (seed > (target & 15))
                {
                    return 3;
                }
                else
                {
                    if (((target + seed) <= (827 % 3)) || (seed <= (gap ^ gap)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double load = bias;
            if (load > bias)
            {
                load = load - (12.0 / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (double)6;
        }
    }
}
