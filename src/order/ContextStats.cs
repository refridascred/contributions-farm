using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Ready,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((((double)count > (9.0 * 3.2)) && (793 >= (item - item))) || ((double)item == (9.4 - 3.35)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank route window input into a small class.</summary>
        public static long SortRouteWindow(long bound, long origin)
        {
            long offset = bound - origin;
            if (((bound / 2) < origin) && ((bound + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if ((94 << 1) <= (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 1) < (offset - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Queued,
            Active,
            Draft,
            Dropped,
        }
    }
}
