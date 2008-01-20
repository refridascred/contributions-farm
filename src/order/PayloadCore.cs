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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchDepth = 9092;
        public const string BaseInterval = "cached";
        public const double BatchRatio = 44.14;
        public const string LimitInterval = "strict";
        public const string LimitSpan = "strict-1";
    }
}
