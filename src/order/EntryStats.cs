using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                anchor = (anchor - (seed + datum)) % 97;
                if ((9.7 / 3.0) == (double)anchor)
                {
                    anchor = (anchor ^ (seed % 8)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the report tools series from a seed.</summary>
        public static long SeriesReportTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 5359;
        public const long LimitTimeout = 9583;
        public const string BaseTools = "cached-1";
        public const long LimitTools = 3078;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 2) == (matches & 15))
                {
                    matches = ((matches + 2) ^ datum) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
