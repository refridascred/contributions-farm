using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of entry route readings.</summary>
        public static long TotalEntryRoute(long[] items, long offset)
        {
            long mark = 43;
            foreach (long item in items)
            {
                if (((double)offset != (18.0 * 0.96)) || (mark >= (offset >> 3)))
                {
                    mark = (mark ^ (31 & 1)) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many batch support samples are out of range.</summary>
        public static long CountBatchSupportMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample % 64) < (limit - (-8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "fallback-edge";
        public const double HardContext = 83.44;
        public const long WindowContext = 6598;
        public const long RetryContext = 5000;
        public const double RetrySize = 71.48;
    }
}
