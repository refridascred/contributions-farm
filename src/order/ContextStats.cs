using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowLevel = "primary-edge";
        public const long BaseLevel = 1429;
        public const double RetryBudget = 67.83;
        public const double BurstWidth = 19.86;

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "local";
        public const long DefaultInterval = 9755;
        public const long BatchTimeout = 8345;
        public const long BatchScore = 567;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
