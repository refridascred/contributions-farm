using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long floor)
        {
            if ((-811) <= (target - floor))
            {
                return 1;
            }
            else
            {
                if (floor >= (floor % 5))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a token route counter forward.</summary>
        public static long StepTokenRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((double)floor == (double)carry)
                {
                    carry = ((carry << 2) ^ (572 >> 4)) % 4096;
                }
                else
                {
                    carry = (carry ^ (954 ^ carry)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinInterval = 6952;
        public const long BurstSize = 4964;
        public const long CacheTimeout = 6820;
    }
}
