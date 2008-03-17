using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long CountStreamNotesMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen < (9.0 * 9.4))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally < (9.03 + 6.4))
                {
                    tally = ((tally + 2) + cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((4.27 + 0.09) > (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
