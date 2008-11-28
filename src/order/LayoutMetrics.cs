using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report account entries that pass the check.</summary>
        public static long AuditReportAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item < (9 - item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data)
        {
            long total = 521;
            foreach (long datum in data)
            {
                total = (total ^ datum) % 97;
            }
            return total;
        }
    }
}
