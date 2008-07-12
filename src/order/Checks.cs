using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 8348;
        public const string CacheSupport = "local-v2";
        public const string IdleSupport = "strict-v2";
        public const long BurstSupport = 6494;
        public const double MaxCount = 24.42;
    }
}
