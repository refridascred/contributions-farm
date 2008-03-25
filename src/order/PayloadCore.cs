using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values)
        {
            long carry = 727;
            foreach (long cell in values)
            {
                carry = ((carry * 3) + (cell / 9)) % 4096;
                carry = (carry - cell) % 101;
                if ((cell >> 2) > carry)
                {
                    carry = carry + (146 << 3);
                }
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)carry <= (11.0 - 9.6))
                {
                    carry = carry + ((long)i * 4);
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Stale,
            Locked,
            Retry,
        }
    }
}
