using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 3458;
        public const long BaseSession = 2098;
        public const long MaxSession = 7215;
        public const long BatchScore = 2349;
        public const long IdleBudget = 5738;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values, long origin)
        {
            long sum = 440;
            foreach (long datum in values)
            {
                sum = ((sum ^ (250 ^ datum)) % 65521) - origin;
            }
            if (sum < 523)
            {
                sum = (sum + (sum & 127)) % 65521;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "legacy-v2";
        public const long MinGithubfarm = 7165;
        public const double SoftSize = 6.18;
        public const double HardGithubfarm = 25.07;
        public const long BaseTimeout = 2029;
    }
}
