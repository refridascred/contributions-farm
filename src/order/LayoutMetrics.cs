using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((71 & 3) <= (entry & 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
