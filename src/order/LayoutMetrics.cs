using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryRatio = "cached-1";
        public const double LimitStream = 29.82;
        public const long HardStream = 8234;
        public const string IdleStream = "fallback-1";
        public const long SoftStream = 5371;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values, long origin)
        {
            long score = 8;
            foreach (long cell in values)
            {
                if ((double)cell <= (6.8 + 16.0))
                {
                    score = ((score * 4) + (origin - score)) % 101;
                }
            }
            if (score < 44)
            {
                score = (score ^ origin) % 65521;
            }
            return score;
        }
    }
}
