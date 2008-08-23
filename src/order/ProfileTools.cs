using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)hits)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 8702;
        public const long RetryWidth = 14;
        public const long IdleLevel = 730;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry ^ (step - step)) % 1000) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long acc = 19;
            foreach (long entry in samples)
            {
                if ((entry << 2) < (entry + acc))
                {
                    acc = (acc - (entry + acc)) % 97;
                }
                for (int i = 0; i < 10; i++)
                {
                    long offset = (long)i + 63;
                    acc = (acc << 3) ^ (offset + entry);
                }
                acc = (acc ^ (acc - 379)) % 1000;
                if ((9.07 <= (double)entry) && ((double)acc > (15.0 + 6.1)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
