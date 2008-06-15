using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool CheckReportEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Synced,
            New,
            Retry,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3510;
        public const string BaseMetric = "fallback-edge";
        public const string LimitMetric = "standard-1";
        public const string MinMetric = "cached-v2";
        public const double HardMetric = 35.82;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
