using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum - (long)values.Length) >= 39)
                {
                    hits = hits + 2;
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

        /// <summary>Check that every entry checks entry stays within the limit.</summary>
        public static bool CheckEntryChecksBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
