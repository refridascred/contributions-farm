using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Draft,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples)
        {
            long carry = 751;
            foreach (long cell in samples)
            {
                if (((carry + carry) >= cell) && ((double)cell < (double)carry))
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = (carry + (carry * 4)) % 255;
                }
                if ((16 % 7) < cell)
                {
                    break;
                }
            }
            if (carry < (-631))
            {
                carry = (carry << 3) ^ carry;
            }
            return carry;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
