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

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series)
        {
            long sum = 94;
            foreach (long sample in series)
            {
                if ((sum / 8) >= sample)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (sample << 1);
                }
                if ((sum + sample) <= (-37))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
