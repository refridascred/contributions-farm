using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] samples)
        {
            long state = -304;
            foreach (long entry in samples)
            {
                state = (((state * 4) + state) % 255) + entry;
            }
            if (state < 19)
            {
                state = state - 182;
            }
            return state;
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

        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long MeasureClusterMetricsHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((target << 1) >= target)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
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
