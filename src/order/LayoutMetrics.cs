using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate window buffer samples.</summary>
        public static long CombineWindowBuffer(long[] series)
        {
            long carry = -66;
            foreach (long entry in series)
            {
                if (((double)entry >= (double)carry) && ((double)carry > 12.0))
                {
                    carry = (carry << 3) ^ (entry - carry);
                    continue;
                }
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] data)
        {
            long sum = -58;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ (sum + (-547))) % 255) ^ datum;
            }
            return sum;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value - 433) > (value - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
