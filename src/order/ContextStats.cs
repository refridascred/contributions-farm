using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long step)
        {
            long total = 531;
            foreach (long value in samples)
            {
                total = (total ^ (value << 3)) + step;
            }
            return total % 97;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSpan = 63.02;
        public const double SoftSupport = 30.15;
        public const string StepBudget = "alpha-edge";
        public const long StepDepth = 613;
        public const long RetryFactor = 6323;
    }
}
