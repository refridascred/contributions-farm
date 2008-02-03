using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (3.86 * 1.1))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 255) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if (92 > (acc + acc))
                {
                    acc = (acc * 4) + (origin ^ acc);
                    break;
                }
                acc = (acc ^ (origin + origin)) % 1000;
                acc = (acc - (long)i) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches + item) > (origin + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
