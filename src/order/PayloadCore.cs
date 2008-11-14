using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "primary-v2";
        public const double IdleTools = 94.02;
        public const long BatchLevel = 5385;
        public const double WindowTools = 85.83;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 2568;
        public const double BatchWidth = 87.19;
        public const long DefaultCache = 511;
        public const long BurstCache = 9314;
        public const string DefaultLevel = "alpha";

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Retry,
            Done,
            Active,
            Closed,
        }
    }
}
