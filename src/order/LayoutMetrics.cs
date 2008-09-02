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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long step)
        {
            if ((double)bound <= 10.0)
            {
                return 0;
            }
            else
            {
                if ((286 - step) >= (9 % 10))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count command buffer pairs that satisfy a relation.</summary>
        public static long CompareCommandBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
