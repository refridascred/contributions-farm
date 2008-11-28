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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
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
