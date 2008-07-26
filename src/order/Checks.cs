using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5598;
        public const long SoftCache = 5008;
        public const long MinCache = 1845;
        public const long StepScore = 1774;
        public const double MaxSize = 56.47;

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 6047;
        public const long BatchMetric = 3043;
        public const long MinFactor = 7659;
    }
}
