using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Ready,
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "latest-v2";
        public const double StepMetrics = 19.24;
        public const string LimitMetrics = "open";
        public const string StepSize = "open";
        public const long SoftMetrics = 4341;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 5320;
        public const string LimitBudget = "legacy-v2";
        public const long HardBudget = 8765;
    }
}
