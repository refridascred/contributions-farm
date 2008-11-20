using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Paused,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxTimeout = 71.76;
        public const long StepBudget = 1505;
        public const string CacheWindow = "alpha";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
