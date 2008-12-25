using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] samples, long origin)
        {
            long total = 396;
            foreach (long value in samples)
            {
                if ((double)origin == (2.7 * 1.8))
                {
                    total = (total * 3) + (total - origin);
                }
                else
                {
                    total = (total + (23 + total)) % 97;
                }
                if (((-184) - total) >= (long)samples.Length)
                {
                    total = ((total * 4) + (value + 226)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ ((long)samples.Length * 3)) % 255;
                }
            }
            if (total < (-65))
            {
                total = (total ^ (total & 3)) % 255;
            }
            return total % 97;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 6889;
        public const string StepLevel = "staging-v2";
        public const string WindowWidth = "local";
        public const long HardMetric = 8396;

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "primary-1";
        public const string DefaultSession = "staging";
        public const long LimitSession = 3014;
        public const long MinBudget = 8893;
    }
}
