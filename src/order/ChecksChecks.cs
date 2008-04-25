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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long origin)
        {
            if (((seed + origin) < (origin & 255)) || ((double)origin < (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) == (origin * 2))
                {
                    return 5;
                }
                else
                {
                    if (((seed >> 2) <= (seed % 7)) && ((867 * 5) >= ((-517) - origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
