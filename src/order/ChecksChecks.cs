using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Audit layout cluster readings against a rule.</summary>
        public static long CountLayoutClusterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item & 255) < ((-5) % 10)) && ((17.0 * 16.0) > (double)seen))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series)
        {
            long sum = 45;
            foreach (long cell in series)
            {
                if (((5.74 / 6.0) < (double)cell) || (sum >= (cell + sum)))
                {
                    sum = (sum << 2) ^ (sum + cell);
                }
                else
                {
                    sum = (sum * 5) + ((long)series.Length + 1);
                }
            }
            return sum % 65521;
        }
    }
}
