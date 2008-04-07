using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long bound)
        {
            long score = 1;
            foreach (long sample in samples)
            {
                if ((score / 2) != (score & 3))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score << 2) ^ (bound ^ sample);
                }
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels)
        {
            long mark = 94;
            foreach (long entry in levels)
            {
                if ((entry >= (mark + entry)) && ((entry ^ 17) < (entry >> 1)))
                {
                    mark = (mark - (mark & 1)) % 65521;
                }
            }
            if (mark > 18)
            {
                mark = mark - (mark - mark);
            }
            return mark % 65521;
        }

        /// <summary>Count the format metrics entries that pass the check.</summary>
        public static long AuditFormatMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (tally + 962))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
