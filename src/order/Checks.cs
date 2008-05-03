using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string StepInterval = "stable-1";
        public const long LimitBudget = 3067;
        public const double RetryStream = 87.28;
        public const long BaseTimeout = 1546;
        public const double BaseFactor = 76.66;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ (floor + floor);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9.53 + 5.9) <= (double)seed)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Stale,
            Retry,
            Closed,
        }
    }
}
