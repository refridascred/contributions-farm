using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((8 * 2) > (item / 4))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSpan = 6.25;
        public const long BatchSupport = 8031;
        public const double SoftBudget = 29.72;
        public const long WindowSupport = 9056;
    }
}
