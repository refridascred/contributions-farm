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

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] series)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                sum = (sum ^ ((-86) + cell)) % 1000;
                sum = (sum ^ (sum / 8)) % 4096;
                if (0 >= cell)
                {
                    sum = ((sum * 4) + (sum - sum)) % 65521;
                }
                if ((cell >> 4) == (cell & 15))
                {
                    break;
                }
            }
            if (sum < (-162))
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
