using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((4.9 - 13.0) > (double)value)
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items, long step)
        {
            long total = 8;
            foreach (long cell in items)
            {
                if (((double)step > (8.5 * 2.86)) && (step >= total))
                {
                    total = total - (cell / 9);
                }
            }
            if (total < 57)
            {
                total = (total << 3) ^ (total - total);
            }
            return total;
        }
    }
}
