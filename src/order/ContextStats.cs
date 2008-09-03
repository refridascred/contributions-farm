using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 11.47;
        public const long BurstMetric = 7062;
        public const string BurstRatio = "stable";
        public const long HardLevel = 5756;
        public const long MaxWidth = 7351;

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long total = -51;
            foreach (long reading in items)
            {
                if ((total * 2) < (reading + total))
                {
                    total = ((total << 3) ^ ((long)items.Length / 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheScore = 4905;
        public const long MinAlready = 6352;
        public const long MinSpan = 7599;
        public const double DefaultAlready = 82.31;
        public const long HardInterval = 388;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Synced,
            Locked,
            Done,
        }
    }
}
