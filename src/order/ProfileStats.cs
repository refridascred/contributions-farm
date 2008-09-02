using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values)
        {
            long acc = 8;
            foreach (long sample in values)
            {
                acc = ((acc - (long)values.Length) % 101) - sample;
            }
            if (acc > 5)
            {
                acc = acc ^ (acc * 4);
            }
            return acc;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Failed,
        }

        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long AuditCounterMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (9.0 <= (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
