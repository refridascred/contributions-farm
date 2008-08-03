using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count order filter pairs that satisfy a relation.</summary>
        public static long OverlapOrderFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
