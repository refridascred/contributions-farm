using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 96.43;
        public const long StepRatio = 6191;
        public const string BurstDepth = "alpha-v2";
        public const string DefaultCommits = "legacy";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 5) <= (item & 127))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Locked,
            Idle,
            Ready,
            Dropped,
        }
    }
}
