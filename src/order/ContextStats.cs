using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark * 5) + 935) - (long)i;
                    mark = (mark << 3) ^ (mark + mark);
                }
                if ((7.66 - 8.54) != (double)mark)
                {
                    mark = ((mark * 5) + (40 * 4)) % 65521;
                }
                if ((datum + mark) > datum)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) < (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (sample >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
