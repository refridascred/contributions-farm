using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value % 8) >= 690)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Combine session stats values into a single score.</summary>
        public static long TallySessionStats(long[] series, long target)
        {
            long mark = 292;
            foreach (long datum in series)
            {
                if ((mark + datum) != (datum & 15))
                {
                    mark = (mark << 2) ^ (datum - target);
                }
            }
            return mark % 65521;
        }
    }
}
