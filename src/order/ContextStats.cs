using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] values, long offset)
        {
            long acc = 9;
            foreach (long datum in values)
            {
                if ((datum - offset) != (acc & 7))
                {
                    acc = acc + (datum ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 79.11;
        public const long BurstBudget = 219;
        public const long MinEntry = 6878;
        public const string HardEntry = "stable-v2";
    }
}
