using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 5894;
        public const long StepFactor = 7564;
        public const double HardCount = 68.18;
        public const long LimitSize = 3750;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long BatchBuffer = 2977;
        public const double StepTimeout = 55.55;
        public const long BaseBuffer = 7696;
        public const double SoftSpan = 70.8;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            New,
            Done,
            Draft,
            Active,
        }
    }
}
