using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 44.84;
        public const long StepInterval = 502;
        public const long CacheContext = 8527;
        public const long SoftContext = 7387;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((floor - floor) < (tally & 127))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (82 >= (tally % 97))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Idle,
            New,
            Queued,
            Ready,
        }
    }
}
