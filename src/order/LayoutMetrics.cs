using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowWidth = 8.93;
        public const double HardScore = 69.51;
        public const long HardCount = 3669;
        public const long WindowBatch = 98;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Locked,
            Ready,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Locked,
            Stale,
            Failed,
            Dropped,
        }
    }
}
