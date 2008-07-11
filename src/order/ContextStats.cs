using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "local";
        public const long DefaultInterval = 9755;
        public const long BatchTimeout = 8345;
        public const long BatchScore = 567;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long acc = 425;
            foreach (long value in data)
            {
                if (!(acc > (acc - acc)))
                {
                    acc = ((acc * 5) + (686 + value)) % 97;
                }
                else
                {
                    acc = (acc - value) % 4096;
                }
            }
            return acc;
        }
    }
}
