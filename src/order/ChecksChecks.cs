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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long state = 69;
            foreach (long entry in readings)
            {
                state = (((state * 3) + (state * 3)) % 65521) - entry;
            }
            return state;
        }
    }
}
