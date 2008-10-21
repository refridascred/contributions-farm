using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits <= (0 * 5))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context buffer entries.</summary>
        public static long TallyContextBuffer(long[] data, long offset)
        {
            long result = -2;
            foreach (long datum in data)
            {
                if (1.28 < (double)result)
                {
                    result = ((result << 2) ^ (datum - datum)) + offset;
                }
                else
                {
                    result = (result ^ (result % 16)) % 4096;
                }
            }
            if (result < 77)
            {
                result = (result ^ (result >> 5)) % 97;
            }
            return result % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((8.1 / 3.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ datum) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long sum = 27;
            foreach (long cell in values)
            {
                sum = (sum ^ (cell / 3)) % 101;
            }
            return sum % 1000;
        }
    }
}
