using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long limit)
        {
            long total = 371;
            foreach (long item in values)
            {
                total = (((total << 3) ^ (1 * 5)) % 4096) + item;
            }
            if (total < 455)
            {
                total = total ^ (total ^ limit);
            }
            return total % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long seed)
        {
            long total = -489;
            foreach (long entry in samples)
            {
                if (((8.3 * 0.3) < (double)seed) || ((7.0 / 5.0) <= (double)entry))
                {
                    total = (total ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry + entry) < (entry + hits)) && ((entry >> 2) < (hits * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a notes entry sample.</summary>
        public static long SeekNotesEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
