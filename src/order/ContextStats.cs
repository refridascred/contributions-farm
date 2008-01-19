using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (51 < hits)
                {
                    hits = (hits + 1) + datum;
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1.34 - 4.51) < (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
