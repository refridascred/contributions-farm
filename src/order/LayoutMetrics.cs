using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen >> 5) != (datum / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 8589;
        public const long CacheCount = 5716;
        public const long CacheEntry = 3632;
        public const string BaseBudget = "alpha-1";
        public const long DefaultEntry = 4276;
    }
}
