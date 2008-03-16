using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Active,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleDepth = 5810;
        public const long StepDepth = 4460;
        public const long RetrySpan = 5744;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Stale,
            Closed,
            Active,
            Failed,
        }
    }
}
