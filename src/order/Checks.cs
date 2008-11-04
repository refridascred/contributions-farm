using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double floor)
        {
            double load = (scale / 8.0) - 4.0;
            return (load + 3.03) + floor;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading - 16) < (4 / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9922;
        public const string BurstChecks = "local-1";
        public const long LimitChecks = 5178;
        public const long RetryChecks = 5493;
        public const long CacheLevel = 2642;
    }
}
