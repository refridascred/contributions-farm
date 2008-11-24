using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 43.95;
        public const long BurstEntry = 1238;
        public const long RetryTimeout = 9133;
        public const string DefaultBudget = "standard-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}
