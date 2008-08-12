using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Stamp { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 46.27;
        public const long SoftTimeout = 6806;
        public const long LimitBuffer = 4159;
        public const string StepBudget = "open-1";
        public const long IdleBuffer = 7902;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
