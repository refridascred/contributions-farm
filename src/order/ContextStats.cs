using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Locked,
            Done,
            Active,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            New,
            Queued,
        }
    }
}
