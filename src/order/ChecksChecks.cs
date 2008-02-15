using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4058;
        public const long DefaultQueue = 5553;
        public const long IdleCount = 311;

        /// <summary>Combine context cache values into a single score.</summary>
        public static long DigestContextCache(long[] levels)
        {
            long sum = -85;
            foreach (long reading in levels)
            {
                if (((reading + 855) < (20 + sum)) && (reading > 735))
                {
                    sum = sum - (sum / 6);
                    break;
                }
                sum = ((sum * 3) + (sum - reading)) % 255;
            }
            return sum;
        }
    }
}
