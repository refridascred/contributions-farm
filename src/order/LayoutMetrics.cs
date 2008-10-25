using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryScore = 62.07;
        public const long BatchWidth = 4819;
        public const long SoftEditor = 6628;
        public const long DefaultBudget = 9280;
    }
}
