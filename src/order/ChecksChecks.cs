using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches > (double)item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long AuditLayoutBufferMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits >= 6.5)
                {
                    hits = ((hits + 3) ^ cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum / 5) < (tally * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
