using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheDepth = "stable-edge";
        public const string IdleCommand = "stable-edge";
        public const long MaxCommand = 8998;
        public const long RetryBudget = 7437;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data)
        {
            long carry = -35;
            foreach (long entry in data)
            {
                carry = carry + (carry + entry);
            }
            if (carry < 189)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (7 + floor)) % 4096;
                if ((floor + result) == (880 + floor))
                {
                    result = result - ((long)i + 4);
                }
                if (((double)(long)i != (double)9) || ((9.8 * 12.0) > (double)floor))
                {
                    result = result + result;
                }
                else
                {
                    result = (result << 3) ^ (floor % 7);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
