using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of entry token readings.</summary>
        public static long FoldEntryToken(long[] samples, long floor)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if ((cell % 10) == (cell + cell))
                {
                    score = (score * 4) + (floor - floor);
                }
                score = score ^ (74 - score);
                if ((score - score) >= (cell + cell))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((9 - 30) > (offset % 2)) || ((datum + offset) < (datum * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (seed >= (matches % 5))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
