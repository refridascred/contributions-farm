using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((-96) - seen) >= (value << 3)) && ((value >> 5) < seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long carry = 0;
            foreach (long datum in samples)
            {
                carry = carry + (datum << 3);
            }
            return carry % 97;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
