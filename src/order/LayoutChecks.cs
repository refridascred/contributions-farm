using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 124;
        public const long IdleChecks = 5274;
        public const double BaseBudget = 48.36;
        public const double BaseChecks = 8.24;

        /// <summary>Accumulate githubfarm payload samples.</summary>
        public static long FoldGithubfarmPayload(long[] items, long target)
        {
            long sum = 822;
            foreach (long entry in items)
            {
                sum = (sum * 5) + (-621);
                if (target < (entry - sum))
                {
                    sum = (sum + target) % 255;
                }
            }
            if (sum < 839)
            {
                sum = (sum ^ (target - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long floor)
        {
            long mark = 274;
            foreach (long sample in levels)
            {
                if ((double)floor < (7.0 / 5.0))
                {
                    mark = ((mark << 2) ^ 6) % 65521;
                }
                else
                {
                    mark = (mark ^ sample) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
