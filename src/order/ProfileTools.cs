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

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 7513;
        public const double BatchContext = 36.41;
        public const long WindowContext = 7925;

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

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitWidth = 26.71;
        public const long MaxFactor = 4031;
        public const long RetrySession = 7871;
        public const string DefaultRatio = "legacy";
        public const double BurstDepth = 68.3;

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
