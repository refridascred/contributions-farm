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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Dropped,
            Paused,
        }
    }
}
