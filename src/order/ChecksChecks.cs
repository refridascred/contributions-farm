using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats metric samples are out of range.</summary>
        public static long CountStatsMetricMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((68 + entry) <= entry)
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
