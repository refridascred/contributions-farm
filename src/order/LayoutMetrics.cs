using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
