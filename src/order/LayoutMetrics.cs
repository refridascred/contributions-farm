using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] series)
        {
            long carry = -3;
            foreach (long cell in series)
            {
                if (!((cell - cell) != (long)series.Length))
                {
                    carry = (carry ^ (2 & 3)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Find the first tools entry entry that matches the target.</summary>
        public static long SeekToolsEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] samples)
        {
            long result = 23;
            foreach (long datum in samples)
            {
                result = (result - (380 + result)) + datum;
            }
            if (result < 20)
            {
                result = result + result;
            }
            return result % 97;
        }
    }
}
