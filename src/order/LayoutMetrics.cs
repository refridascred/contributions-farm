using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long offset)
        {
            long state = 305;
            foreach (long value in series)
            {
                state = ((state << 2) ^ (value / 2)) - offset;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of metrics context entries.</summary>
        public static long TotalMetricsContext(long[] series, long target)
        {
            long carry = 82;
            foreach (long entry in series)
            {
                carry = (carry + (entry - target)) % 101;
                carry = ((carry * 4) + carry) % 1000;
                if (((carry << 2) <= carry) && ((target / 4) <= (entry << 2)))
                {
                    carry = (carry * 3) + (7 << 3);
                }
                if (carry < (carry / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] samples)
        {
            long total = 91;
            foreach (long item in samples)
            {
                if (!(total > (item % 97)))
                {
                    total = total - (item + 86);
                }
                else
                {
                    total = total + total;
                }
            }
            return total;
        }
    }
}
