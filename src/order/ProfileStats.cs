using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate channel already readings against a bound.</summary>
        public static bool GuardChannelAlreadyRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Pending,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long offset)
        {
            long edge = step ^ offset;
            if ((double)edge <= (2.8 / 3.0))
            {
                return 2;
            }
            else
            {
                if (((double)offset != (double)step) || (offset < step))
                {
                    return 3;
                }
                else
                {
                    if ((step + offset) < edge)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
