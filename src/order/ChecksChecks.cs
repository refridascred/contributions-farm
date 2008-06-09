using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseBudget = "alpha-v2";
        public const long BaseMetrics = 8126;
        public const long DefaultMetrics = 6774;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            New,
            Draft,
            Done,
            Idle,
        }
    }
}
