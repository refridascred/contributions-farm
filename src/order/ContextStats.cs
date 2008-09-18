using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long limit)
        {
            long total = 371;
            foreach (long item in values)
            {
                total = (((total << 3) ^ (1 * 5)) % 4096) + item;
            }
            if (total < 455)
            {
                total = total ^ (total ^ limit);
            }
            return total % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long seed)
        {
            long total = -489;
            foreach (long entry in samples)
            {
                if (((8.3 * 0.3) < (double)seed) || ((7.0 / 5.0) <= (double)entry))
                {
                    total = (total ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Idle,
            Active,
            New,
        }
    }
}
