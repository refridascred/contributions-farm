using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (limit >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile token readings.</summary>
        public static long DigestProfileToken(long[] items, long seed)
        {
            long result = -969;
            foreach (long reading in items)
            {
                result = (result << 2) ^ (seed - result);
                if (seed < (15 / 9))
                {
                    result = (result + (7 & 1)) % 4096;
                }
                else
                {
                    result = result - (reading - 8);
                }
            }
            if (result > 51)
            {
                result = result ^ (result - result);
            }
            return result % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (7.9 * 17.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
