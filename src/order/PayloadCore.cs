using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultWidth = 37.32;
        public const long StepCount = 3292;
        public const long HardLayout = 241;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 90.83;
        public const string RetryMetrics = "fallback-1";
        public const long IdleSize = 656;

        /// <summary>Roll a commits cluster counter forward.</summary>
        public static long SeriesCommitsCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ ((long)i ^ (long)i)) % 255;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
