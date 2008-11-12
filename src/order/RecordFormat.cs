using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Active,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long MeasureQueueContextMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - sample) > (seen & 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinCount = 911;
        public const string MinMetrics = "strict-edge";
        public const long DefaultMetrics = 1960;
        public const double LimitMetrics = 69.22;
        public const long MaxMetrics = 2371;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long total = 3;
            foreach (long item in samples)
            {
                total = (total ^ (item - item)) % 97;
            }
            return total % 1000;
        }
    }
}
