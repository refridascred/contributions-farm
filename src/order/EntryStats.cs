using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 2291;
        public const double BurstInterval = 81.36;
        public const double DefaultWindow = 89.04;
        public const long StepCount = 653;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Pending,
            New,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardBudget = 49.79;
        public const double LimitOrder = 45.48;
        public const long BurstSize = 8931;
        public const long WindowOrder = 5281;
        public const double HardOrder = 92.32;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 5707;
        public const string DefaultLevel = "fallback-v2";
        public const long SoftBatch = 5523;
        public const long BaseLevel = 8095;
    }
}
