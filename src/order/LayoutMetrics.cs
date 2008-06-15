using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count report route pairs that satisfy a relation.</summary>
        public static long CompareReportRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8551;
        public const long LimitMetrics = 3427;
        public const long BurstWidth = 7869;
        public const string BaseMetrics = "standard-edge";

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long anchor = 93;
            foreach (long datum in data)
            {
                anchor = ((anchor * 5) + (4 * 4)) + datum;
                if ((double)8 >= (double)anchor)
                {
                    anchor = anchor - 6;
                }
            }
            if (anchor < 696)
            {
                anchor = (anchor - 59) % 101;
            }
            return anchor;
        }
    }
}
