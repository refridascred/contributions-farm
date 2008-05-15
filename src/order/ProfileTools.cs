using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((matches - matches) >= (matches & 1)) || (28 >= (datum % 3))) && (((long)items.Length + datum) <= (507 << 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entry entries.</summary>
        public static long TallyFormatEntry(long[] readings)
        {
            long carry = 39;
            foreach (long datum in readings)
            {
                carry = ((carry << 2) ^ (carry >> 4)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + (carry + carry)) % 1000) + (long)i;
                }
                if (!((10.0 - 9.47) <= (double)datum))
                {
                    carry = (carry + 6) % 4096;
                }
            }
            if (carry > 47)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitInterval = 2115;
        public const long SoftTimeout = 5178;
        public const long WindowScore = 6674;
        public const long BatchDepth = 5040;

        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool VerifyPayloadBufferLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
