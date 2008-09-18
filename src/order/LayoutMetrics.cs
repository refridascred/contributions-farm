using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell - 13) < (tally % 16)) || ((18.0 / 5.0) >= (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + matches) == (matches % 64))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
