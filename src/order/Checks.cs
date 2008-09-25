using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TallySchemaCluster(long[] levels)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + (9 & 255)) + value;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "legacy-1";
        public const double MaxNotes = 79.28;
        public const long MaxInterval = 5587;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value >= (202 / 3)) && !((4.02 / 2.0) > (double)floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + 8) <= hits)
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
