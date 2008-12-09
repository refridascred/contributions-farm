using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen / 6) < (seen % 5)) || ((value - seen) <= (846 & 15)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (566 < (entry + entry))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
