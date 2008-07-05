using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate contributi already readings against a bound.</summary>
        public static bool ValidateContributiAlreadyLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support checks readings.</summary>
        public static long FoldSupportChecks(long[] items, long offset)
        {
            long anchor = 98;
            foreach (long entry in items)
            {
                if ((anchor * 3) <= (entry + offset))
                {
                    anchor = anchor - (offset + 691);
                }
            }
            return anchor;
        }
    }
}
