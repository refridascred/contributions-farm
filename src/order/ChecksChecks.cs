using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a cluster metrics value against two limits.</summary>
        public static long SortClusterMetrics(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((next <= (seed2 & 127)) || ((seed2 - seed2) != ((-30) + next)))
            {
                return 3;
            }
            else
            {
                if ((next & 255) == (seed2 * 2))
                {
                    return 4;
                }
                else
                {
                    if ((0.06 - 4.9) < (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryTimeout = 9848;
        public const long BurstTimeout = 366;
        public const long BurstSchema = 9489;
        public const long IdleSchema = 5426;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Draft,
            Dropped,
            Stale,
            Locked,
        }
    }
}
