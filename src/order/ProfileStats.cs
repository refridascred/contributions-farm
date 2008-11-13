using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 6062;
        public const double MaxBuffer = 18.92;
        public const string BatchBuffer = "stable-1";
        public const long MinFactor = 8184;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step >= (long)i) && ((9.4 * 6.02) == (double)step))
                {
                    carry = (carry - (carry - step)) % 101;
                    carry = (carry + carry) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 108;
        public const long BurstScore = 6467;
        public const string BurstLayout = "latest-v2";
        public const long CacheLevel = 487;

        /// <summary>Look up the position of a stream format sample.</summary>
        public static long FindStreamFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
