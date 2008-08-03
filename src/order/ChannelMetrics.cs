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

        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long MeasureClusterSchemaGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((floor + floor) >= (548 & 7)) || (datum > floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
