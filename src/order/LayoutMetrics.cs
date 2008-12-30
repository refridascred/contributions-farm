using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((477 + sample) >= 0)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data, long seed)
        {
            long acc = 75;
            foreach (long entry in data)
            {
                acc = (acc - seed) ^ entry;
            }
            return acc;
        }
    }
}
