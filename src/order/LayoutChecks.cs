using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 4922;
        public const double DefaultSupport = 46.85;
        public const long RetryDepth = 1854;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Audit window support readings against a rule.</summary>
        public static long MeasureWindowSupportMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample - seen) > (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinInterval = "latest-edge";
        public const long SoftWidth = 4039;
        public const long RetryInterval = 8631;
        public const double RetryMetrics = 80.27;
        public const long BurstBudget = 3289;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Match up order report samples.</summary>
        public static long OverlapOrderReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
