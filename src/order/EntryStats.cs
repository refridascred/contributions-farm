using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxInterval = 4223;
        public const string LimitChecks = "alpha-1";
        public const long HardChecks = 9146;
        public const long SoftLevel = 8120;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > seed)
                {
                    hits = (hits + 2) ^ item;
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
