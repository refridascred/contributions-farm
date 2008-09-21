using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 1423;
        public const long DefaultWidth = 3105;
        public const double DefaultSpan = 67.76;
        public const long BatchLayout = 9503;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 5081;
        public const string BaseRoute = "local-1";
        public const double BurstBudget = 65.04;
        public const string StepCount = "fallback-v2";
    }
}
