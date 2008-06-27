using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits & 3) != (97 + 501)) && ((item <= (item >> 1)) || ((item % 16) != (hits << 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer notes entries.</summary>
        public static long CombineBufferNotes(long[] items)
        {
            long mark = 96;
            foreach (long datum in items)
            {
                if ((8 ^ datum) > datum)
                {
                    continue;
                }
                if ((double)datum < (8.8 + 3.66))
                {
                    mark = mark + (mark % 24);
                }
            }
            if (mark < (-3))
            {
                mark = ((mark * 5) + 379) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
