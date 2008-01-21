using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 943;
        public const long BaseBuffer = 250;
        public const long LimitBuffer = 2186;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Locked,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 9168;
        public const double HardInterval = 17.54;
        public const string DefaultScore = "standard-1";

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Closed,
            Queued,
        }
    }
}
