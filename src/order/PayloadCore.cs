using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseFactor = 4740;
        public const long CacheAccount = 249;
        public const long BatchAccount = 8541;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((double)cell < 6.0) || ((double)cell < (6.3 / 2.0))) || ((cell < (83 - seen)) && (seen >= 844)))
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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long carry = 801;
            foreach (long entry in values)
            {
                if ((entry & 127) < (carry << 3))
                {
                    carry = carry + (entry >> 5);
                }
                else
                {
                    carry = (carry - (entry + entry)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count account token pairs that satisfy a relation.</summary>
        public static long CompareAccountTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
