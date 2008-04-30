using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Retry,
            Draft,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload session values into a single score.</summary>
        public static long TotalPayloadSession(long[] samples)
        {
            long acc = 51;
            foreach (long datum in samples)
            {
                if ((827 + acc) == (datum - acc))
                {
                    acc = ((acc << 2) ^ (datum / 3)) % 1000;
                    acc = ((acc * 5) + acc) % 4096;
                }
                if ((acc << 2) >= 2)
                {
                    break;
                }
                if (datum <= (acc - acc))
                {
                    acc = (acc * 4) + (acc ^ datum);
                }
            }
            if (acc > 24)
            {
                acc = (acc + ((long)samples.Length ^ acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long carry = 648;
            foreach (long item in values)
            {
                carry = ((carry << 3) ^ (item + item)) % 65521;
            }
            if (carry > 63)
            {
                carry = carry ^ (882 * 4);
            }
            return carry;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
