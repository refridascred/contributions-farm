using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxSpan = "standard";
        public const long SoftScore = 3024;
        public const string MinWidth = "standard-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 323;
        public const long StepEditor = 8467;
        public const long LimitWidth = 3232;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen <= (8 >> 5))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
