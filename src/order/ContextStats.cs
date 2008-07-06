using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series, long floor)
        {
            long acc = 635;
            foreach (long reading in series)
            {
                acc = (((acc + (82 + (long)series.Length)) % 255) - reading) + floor;
            }
            return acc % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryBudget = 2888;
        public const long BatchLevel = 8440;
        public const long BurstRatio = 3597;
        public const double BaseTimeout = 61.71;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
