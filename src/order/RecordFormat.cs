using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every tools profile entry stays within the limit.</summary>
        public static bool VerifyToolsProfileLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long limit)
        {
            long mark = 8;
            foreach (long value in items)
            {
                mark = (mark + mark) % 101;
                if (((6 ^ value) > limit) && ((mark + 0) < limit))
                {
                    mark = ((mark << 2) ^ limit) % 255;
                }
            }
            return mark;
        }

        /// <summary>Iterate the metrics order series from a seed.</summary>
        public static long StepMetricsOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - carry) % 65521;
                if ((carry << 2) != (offset << 1))
                {
                    carry = carry ^ carry;
                }
                carry = (carry - ((long)i * 2)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels)
        {
            long state = 3;
            foreach (long cell in levels)
            {
                state = ((state * 4) + (state - cell)) % 97;
            }
            if (state > 11)
            {
                state = ((state * 2) + (state / 4)) % 97;
            }
            return state;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long limit)
        {
            long carry = 928;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ limit) % 65521) ^ value;
            }
            return carry % 65521;
        }
    }
}
