using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftBudget = 5246;
        public const double CacheRatio = 29.49;
        public const long WindowNotes = 384;
        public const long IdleSpan = 4023;
        public const long MaxNotes = 4438;
    }
}
