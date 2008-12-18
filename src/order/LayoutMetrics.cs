using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long score = 20;
            foreach (long cell in items)
            {
                score = (score + (cell + cell)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Audit checks window readings against a rule.</summary>
        public static long AuditChecksWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)hits > (double)entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value + value) <= (bound + bound)) && ((value ^ bound) >= (62 ^ (-4))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
