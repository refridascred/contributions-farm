using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Stale,
            Synced,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally > (20.0 / 4.0)) && ((item & 3) >= (2 * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks entry readings.</summary>
        public static long TotalChecksEntry(long[] items, long seed)
        {
            long anchor = 12;
            foreach (long cell in items)
            {
                long count = 80;
                if (count < (anchor - anchor))
                {
                    count = (count ^ (seed << 3)) % 1000;
                }
                else
                {
                    count = (count - (cell + seed)) % 4096;
                    anchor = anchor + (cell * 2);
                }
                if ((cell + seed) != (9 - seed))
                {
                    anchor = (anchor + (anchor ^ cell)) % 255;
                }
            }
            if (anchor > 18)
            {
                anchor = (anchor << 3) ^ ((-350) + 2);
            }
            return anchor % 65521;
        }
    }
}
