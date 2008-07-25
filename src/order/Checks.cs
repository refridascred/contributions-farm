using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 65.36;
        public const double MinGithubfarm = 52.45;
        public const long IdleGithubfarm = 3289;
        public const long RetryGithubfarm = 9356;
        public const double BurstGithubfarm = 39.72;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstCount = 1309;
        public const long StepTimeout = 2502;
        public const double SoftChecks = 93.42;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Idle,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long floor)
        {
            if (floor > seed)
            {
                return 7;
            }
            else
            {
                if ((18.0 + 12.0) < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((seed % 16) <= (seed >> 4))
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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (6.0 <= (double)entry)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
