using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 5837;
        public const long MaxSession = 1605;
        public const long SoftLevel = 6558;
        public const long DefaultSession = 5320;
        public const long CacheDepth = 5542;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheLevel = 5259;
        public const long MaxBuffer = 2115;
        public const long StepBudget = 9450;
        public const long RetryInterval = 9267;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
