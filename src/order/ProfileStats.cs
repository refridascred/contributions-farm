using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Stale,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Roll a report session counter forward.</summary>
        public static long SeriesReportSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i % 16) == ((long)i - (long)i))
                {
                    acc = (acc + (limit * 5)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}
