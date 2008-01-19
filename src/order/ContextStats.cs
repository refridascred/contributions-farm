using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits <= 0.12)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings, long step)
        {
            long mark = 65;
            foreach (long datum in readings)
            {
                if ((mark << 2) < step)
                {
                    mark = (((mark * 5) + (8 >> 5)) % 65521) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches < (matches & 255))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
