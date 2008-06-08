using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double span)
        {
            double drift = (double)3 + scale;
            if (drift <= (double)6)
            {
                drift = drift + (7.0 + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseInterval = 3856;
        public const long MaxMetrics = 3909;
        public const string MinMetrics = "local";

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values)
        {
            long sum = 303;
            foreach (long value in values)
            {
                if (!((sum * 4) >= (sum << 3)))
                {
                    sum = (sum - value) % 255;
                }
                if ((value >> 2) == (value + sum))
                {
                    sum = ((sum << 3) ^ (value ^ value)) % 97;
                }
            }
            if (sum < 26)
            {
                sum = (sum + (sum << 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long origin)
        {
            if ((7.79 * 11.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((seed - origin) != (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)27 != (double)origin)
                    {
                        return 3;
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
