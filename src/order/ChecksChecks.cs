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

        /// <summary>Find the first batches order entry that matches the target.</summary>
        public static long FindBatchesOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
