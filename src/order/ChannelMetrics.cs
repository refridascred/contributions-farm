using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank report commits input into a small class.</summary>
        public static long SortReportCommits(long bound, long offset)
        {
            long cur = bound - offset;
            if ((cur - cur) == (bound ^ (-21)))
            {
                return 5;
            }
            else
            {
                if (((cur << 3) > (bound + offset)) || ((cur / 4) < (10 - cur)))
                {
                    return 6;
                }
                else
                {
                    if (((offset % 5) < cur) || (bound >= (bound * 3)))
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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
