using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Draft,
            Done,
        }

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

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 2797;
        public const string DefaultSpan = "strict-1";
        public const long LimitCounter = 1714;

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
