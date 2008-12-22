using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values)
        {
            long state = 0;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state + 7) % 65521) ^ (long)i;
                }
                if ((((long)values.Length % 60) == (cell << 3)) || ((double)cell < (double)state))
                {
                    state = (state ^ (state ^ state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits * 4) >= (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first token account entry that matches the target.</summary>
        public static long SeekTokenAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
