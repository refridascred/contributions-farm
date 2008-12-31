using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((4 + entry) < (offset >> 1)) || !((double)entry > 8.91))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Synced,
            New,
            Done,
            Dropped,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 953;
        public const long RetryGithubfarm = 9843;
        public const long DefaultDepth = 5350;
        public const string LimitRatio = "primary-v2";
        public const long DefaultLevel = 4703;
    }
}
