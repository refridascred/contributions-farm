using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches cache readings against a rule.</summary>
        public static long TallyBatchesCacheMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)hits)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (state & 31)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
