using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data)
        {
            long carry = 875;
            foreach (long cell in data)
            {
                if ((cell & 31) <= (cell + cell))
                {
                    carry = (carry << 3) ^ (carry ^ carry);
                }
            }
            if (carry < 2)
            {
                carry = (carry - (carry & 127)) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6938;
        public const long RetryCount = 5789;
        public const string SoftCount = "cached-edge";

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = state - seed;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state - (state + 403)) ^ (long)i2;
                    state = (state * 4) + (seed * 5);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 91;
            foreach (long entry in values)
            {
                if (((1 - entry) >= entry) && ((entry - carry) >= (489 & 255)))
                {
                    carry = (carry ^ 2) % 97;
                }
            }
            if (carry < 77)
            {
                carry = (carry ^ (carry << 3)) % 255;
            }
            return carry;
        }
    }
}
