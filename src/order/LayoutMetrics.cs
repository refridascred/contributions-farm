using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long offset)
        {
            long carry = 44;
            foreach (long value in data)
            {
                carry = ((carry * 3) + value) % 1000;
                if (((double)offset >= 4.6) || (42 > (value * 3)))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry ^ (value - carry)) % 65521;
                }
                if (((carry + value) > (value + carry)) && ((double)82 <= (double)carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Locked,
            Paused,
            Dropped,
        }
    }
}
