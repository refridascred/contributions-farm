using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i % 12) == (offset / 9))
                {
                    carry = carry ^ ((long)i % 5);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1489;
        public const string HardDepth = "open-edge";
        public const long IdleOrder = 3486;

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 - bias) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (12.0 - bias2)) + (double)(long)i;
            }
            return bias2 - (double)18;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
