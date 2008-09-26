using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Paused,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Synced,
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "stable-v2";
        public const long BaseTimeout = 848;
        public const long HardCommand = 7834;
        public const long WindowCommand = 3458;
        public const long MinCommand = 8022;
    }
}
