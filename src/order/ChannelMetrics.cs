using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] values)
        {
            long carry = 45;
            foreach (long value in values)
            {
                carry = (((carry * 5) + (38 + carry)) % 101) - value;
            }
            return carry % 65521;
        }
    }
}
