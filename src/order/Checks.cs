using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 1390;
        public const long WindowOrder = 7744;
        public const long MinBudget = 2087;
        public const long WindowWidth = 5287;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value - 98) > (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Ready,
            Idle,
            Retry,
        }
    }
}
