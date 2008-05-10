using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + carry) ^ sample;
            }
            if (carry < 636)
            {
                carry = ((carry << 3) ^ seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count == (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = total ^ (4 / 5);
                if (((total / 3) < total) || ((bound + bound) != (7 >> 1)))
                {
                    total = ((total * 3) + (total >> 2)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4361;
        public const long BaseBudget = 5047;
        public const long CacheEntry = 9248;
    }
}
