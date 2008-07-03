using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long bound)
        {
            long carry = 5;
            foreach (long reading in items)
            {
                if ((double)reading > (double)bound)
                {
                    carry = (carry * 5) + (bound % 2);
                }
            }
            if (carry > 63)
            {
                carry = carry ^ (bound * 4);
            }
            return carry % 1000;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (14 > (seen + limit))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
