using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 2161;
        public const long MaxRecord = 8370;
        public const double BatchRecord = 25.31;
        public const string HardTimeout = "stable-v2";
        public const long LimitRecord = 5583;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 3) ^ (long)i;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 1319;
        public const long RetryFilter = 5167;
        public const long StepFilter = 9739;
    }
}
