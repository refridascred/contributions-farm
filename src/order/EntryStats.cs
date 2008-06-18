using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "local-1";
        public const string BurstWindow = "local-1";
        public const long CacheWindow = 9364;
        public const double RetryWindow = 36.18;
        public const long SoftWindow = 989;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Pending,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate report order readings against a bound.</summary>
        public static bool CheckReportOrderRange(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
