using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowInterval = 69.23;
        public const long HardSession = 9181;
        public const string MinSession = "cached-1";
        public const long StepSession = 2081;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7235;
        public const long BurstLevel = 4986;
        public const long DefaultSpan = 8527;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i >= (335 & 255)) && (((long)i - carry) < bound))
                {
                    carry = carry ^ (carry % 12);
                    carry = (carry << 3) ^ carry;
                }
                carry = (carry + carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
