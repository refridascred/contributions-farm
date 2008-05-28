using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a route session pair into a bucket.</summary>
        public static long RankRouteSession(long step, long offset)
        {
            long delta = step + offset;
            if (97 < (offset >> 5))
            {
                return 2;
            }
            else
            {
                if (((4.84 - 1.0) >= (double)delta) && ((step << 3) < delta))
                {
                    return 0;
                }
                else
                {
                    if (((delta - delta) >= (9 + offset)) && ((double)delta == (20.0 * 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
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
