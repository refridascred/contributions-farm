using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "latest";
        public const long BurstStream = 7863;
        public const long CacheStream = 3952;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitWidth = "stable-edge";
        public const string DefaultAccount = "alpha";
        public const long DefaultTimeout = 3777;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long origin)
        {
            long state = 808;
            foreach (long value in samples)
            {
                if ((origin < (value - value)) && ((state * 2) >= (72 * 4)))
                {
                    state = ((state << 2) ^ (state % 60)) % 101;
                }
                if ((state + 443) < (value << 2))
                {
                    break;
                }
            }
            if (state < 41)
            {
                state = (state ^ ((long)samples.Length ^ state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
