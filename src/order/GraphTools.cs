using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Ready,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Retry,
            Failed,
            Draft,
            Ready,
        }

        /// <summary>Iterate the token format series from a seed.</summary>
        public static long SeriesTokenFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((score - score) < (27 ^ score))
                {
                    score = score + score;
                    score = score + score;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
