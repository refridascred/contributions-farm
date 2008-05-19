using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine already filter values into a single score.</summary>
        public static long CombineAlreadyFilter(long[] series, long floor)
        {
            long carry = 68;
            foreach (long value in series)
            {
                if (((double)23 == (double)carry) || ((798 / 3) != (value >> 5)))
                {
                    carry = ((carry + (carry << 1)) % 97) + floor;
                }
                else
                {
                    carry = ((carry * 2) + (value + value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Synced,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many metrics stream samples are out of range.</summary>
        public static long TallyMetricsStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ count) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
