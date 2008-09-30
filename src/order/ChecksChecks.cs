using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double weight = span;
            if (weight < (double)28)
            {
                weight = (weight - (weight + span)) - ratio;
            }
            return weight + span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchTimeout = 2177;
        public const long BurstCommits = 2160;
        public const long RetryCommits = 4519;
        public const long WindowCommits = 3891;
        public const long BatchCommits = 693;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            if ((origin + limit) == (limit >> 5))
            {
                return 0;
            }
            else
            {
                if ((limit & 7) < (origin & 31))
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
}
