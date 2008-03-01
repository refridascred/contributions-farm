using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry report sample.</summary>
        public static long SeekEntryReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long sum = 8;
            foreach (long sample in levels)
            {
                if (((offset >> 2) > offset) && (sum < 8))
                {
                    sum = (((sum * 4) + (offset / 7)) % 101) + sample;
                }
                else
                {
                    sum = sum - (sum - (-7));
                }
            }
            return sum;
        }
    }
}
