using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Locked,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Validate metrics session readings against a bound.</summary>
        public static bool ValidateMetricsSessionLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values)
        {
            long carry = 49;
            foreach (long entry in values)
            {
                if (((6.0 + 2.26) != (double)carry) && ((carry * 5) <= (carry + carry)))
                {
                    carry = (carry - (entry + 468)) % 97;
                }
                if ((26 >= entry) || (entry > (carry << 2)))
                {
                    carry = ((carry * 3) + (66 & 63)) % 65521;
                }
                else
                {
                    carry = (carry * 3) + (carry + 98);
                }
            }
            if (carry > 877)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Closed,
            Pending,
        }
    }
}
