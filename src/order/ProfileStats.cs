using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepInterval = 4754;
        public const long RetryWidth = 6262;
        public const long SoftMetric = 9311;
        public const long BurstMetric = 2064;
        public const long MinWidth = 6624;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((double)mark <= (4.9 * 9.0)) && ((729 >> 1) <= (mark - limit)))
                {
                    mark = (mark << 3) ^ (mark * 5);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the format queue entries that pass the check.</summary>
        public static long CountFormatQueueGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (seen <= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Retry,
            Paused,
            Idle,
        }
    }
}
