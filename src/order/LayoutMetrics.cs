using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftLevel = 1842;
        public const long MaxSpan = 8642;
        public const long WindowSupport = 5977;
    }
}
