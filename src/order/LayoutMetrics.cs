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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (double)662)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
