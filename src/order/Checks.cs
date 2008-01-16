using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 12) < (216 % 97))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length >> 4) <= (reading >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long CountFormatNotesMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (3.0 - 12.0))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next token profile value from a seed.</summary>
        public static long SeriesTokenProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((mark % 12) != (89 / 6)) && ((offset - mark) != (18 ^ 386)))
                {
                    mark = mark + offset;
                    continue;
                }
                mark = mark + (mark ^ mark);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
