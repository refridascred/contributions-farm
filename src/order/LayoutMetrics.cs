using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)(-7) <= (double)reading)
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)hits > 19.0)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((418 + item) <= (count * 5))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
