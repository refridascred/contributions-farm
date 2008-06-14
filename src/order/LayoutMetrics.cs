using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Retry,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 50.84;
        public const double RetryFarm = 83.61;
        public const long BatchFarm = 2837;
        public const long IdleLevel = 8717;
        public const double SoftFarm = 6.78;
    }
}
