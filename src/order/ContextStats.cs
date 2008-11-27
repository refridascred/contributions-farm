using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepTimeout = 6297;
        public const long LimitTimeout = 4946;
        public const double DefaultAccount = 29.98;
        public const double IdleAccount = 13.83;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Idle,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 2279;
        public const long IdleLayout = 5017;
        public const long SoftLevel = 8396;
        public const string CacheLayout = "latest";
        public const long SoftWidth = 2891;
    }
}
