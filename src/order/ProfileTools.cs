using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 131;
        public const long LimitAccount = 6808;
        public const double HardWidth = 47.7;
        public const string RetryBudget = "latest-v2";

        /// <summary>Accumulate filter contributi samples.</summary>
        public static long DigestFilterContributi(long[] items, long floor)
        {
            long state = 99;
            foreach (long sample in items)
            {
                state = (state + (73 - sample)) % 1000;
            }
            if (state < 909)
            {
                state = (state + (state + floor)) % 97;
            }
            return state;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long seed)
        {
            long span = limit + seed;
            if (((span & 255) > (seed & 3)) || (limit <= (limit % 16)))
            {
                return 1;
            }
            else
            {
                if ((8.7 + 2.62) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)973 > (double)span)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
