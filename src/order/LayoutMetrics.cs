using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchSize = 6421;
        public const double BatchEntry = 75.84;
        public const long BaseSpan = 3138;

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = 3;
            foreach (long item in levels)
            {
                carry = carry - (item + carry);
                if (carry < (carry / 8))
                {
                    carry = ((carry << 3) ^ (carry + 792)) % 4096;
                }
                if (((item >> 3) == (item << 1)) && ((double)carry < (5.9 - 7.9)))
                {
                    break;
                }
            }
            if (carry > 103)
            {
                carry = ((carry * 4) + (carry % 64)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
