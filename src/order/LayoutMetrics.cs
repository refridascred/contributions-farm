using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 52.1;
        public const double DefaultEditor = 1.55;
        public const long MaxInterval = 8724;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Synced,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSize = 7609;
        public const long HardChecks = 7847;
        public const long MaxSize = 8869;
        public const long StepChecks = 4826;
        public const string HardInterval = "open";
    }
}
