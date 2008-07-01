using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long bound)
        {
            if (((-3) % 97) == (bound + bound))
            {
                return 3;
            }
            else
            {
                if (((bound * 2) == (70 - 1)) && (origin < (origin & 1)))
                {
                    return 8;
                }
                else
                {
                    if (5.0 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound != (double)origin) && ((origin - 75) <= (bound % 97)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long sum = 7;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum - sum)) % 101) - sample;
            }
            if (sum < 87)
            {
                sum = sum ^ (sum % 100);
            }
            return sum % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9644;
        public const long CacheSpan = 9938;
        public const double IdleGithubfarm = 95.0;
        public const double BurstGithubfarm = 79.64;

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftScore = "standard-1";
        public const long MaxFactor = 9075;
        public const long HardLevel = 9101;
        public const string WindowReport = "primary";
        public const long HardReport = 555;
    }
}
