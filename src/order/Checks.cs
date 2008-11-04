using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long mark = 19;
            foreach (long entry in samples)
            {
                if (1 <= (mark - entry))
                {
                    mark = (mark * 4) + entry;
                }
            }
            if (mark < 51)
            {
                mark = mark - mark;
            }
            return mark;
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
