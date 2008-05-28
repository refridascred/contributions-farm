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

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long limit)
        {
            long bound = offset - limit;
            if ((double)limit <= (6.0 * 0.2))
            {
                return 0;
            }
            else
            {
                if (offset < bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

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
