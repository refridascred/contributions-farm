using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6850;
        public const double LimitDepth = 27.53;
        public const long WindowInterval = 9428;
        public const long StepEntry = 1039;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Done,
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values, long floor)
        {
            long sum = 431;
            foreach (long sample in values)
            {
                if (((sample + sample) >= sum) && ((284 * 2) < floor))
                {
                    sum = sum - (602 + floor);
                }
            }
            if (sum < 70)
            {
                sum = sum ^ 8;
            }
            return sum;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            New,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Locked,
            Closed,
        }
    }
}
