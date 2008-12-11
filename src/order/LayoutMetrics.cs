using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series, long offset)
        {
            long carry = 93;
            foreach (long datum in series)
            {
                if ((double)datum != (double)offset)
                {
                    carry = (carry ^ (offset % 10)) % 97;
                }
                else
                {
                    carry = (carry + (carry ^ offset)) % 65521;
                }
                if (((double)carry != (7.0 + 9.73)) || ((carry & 3) < datum))
                {
                    break;
                }
            }
            if (carry < 36)
            {
                carry = carry + (offset * 5);
            }
            return carry % 1000;
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool ValidateGraphLayoutRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
