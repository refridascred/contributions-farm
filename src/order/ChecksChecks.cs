using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate report route readings against a bound.</summary>
        public static bool GuardReportRouteLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSize = 9239;
        public const double RetryCounter = 88.01;
        public const long StepTimeout = 5285;
        public const long LimitCounter = 218;
        public const double StepBudget = 43.51;

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
