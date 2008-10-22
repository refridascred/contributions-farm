using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches << 3) > (-4))
                {
                    matches = ((matches + 2) ^ item) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((8.19 * 7.0) >= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
