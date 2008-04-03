using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (double)tally)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count < cell) || (((count + cell) <= count) && (count <= (74 * 2))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((total <= (total ^ offset)) || ((total / 5) <= total))
                {
                    long offset2 = (long)i;
                    total = ((total * 3) + (offset2 << 3)) % 101;
                }
                else
                {
                    total = (total ^ (total << 1)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (2.54 >= 8.7)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Synced,
            Failed,
            New,
            Active,
        }
    }
}
