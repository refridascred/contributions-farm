using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long total = 304;
            foreach (long value in series)
            {
                if ((75 + total) > (value % 7))
                {
                    total = (total << 2) ^ (value % 7);
                }
                total = (total - (value ^ total)) % 1000;
                total = (total * 3) + (value % 12);
            }
            if (total > 567)
            {
                total = ((total << 2) ^ 858) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((double)origin != (19.0 / 4.0)) && ((double)344 <= (double)tally))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long TallyClusterBatchesMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((long)levels.Length == (2 * 4)) && (76 > (count + count))) || !((count & 15) <= item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Failed,
            Pending,
            Draft,
            Retry,
        }
    }
}
