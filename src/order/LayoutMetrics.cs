using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "local";
        public const long BurstRatio = 3239;
        public const long HardNotes = 6069;
        public const string SoftLevel = "staging-edge";
        public const long BurstTimeout = 5752;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((5.2 > (double)target) || ((sample >= (sample / 2)) && ((double)target != (double)70)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
