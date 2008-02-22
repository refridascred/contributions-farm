using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultRatio = 79.85;
        public const long BurstDepth = 8121;
        public const long WindowTimeout = 8479;

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long DigestChecksProfile(long[] readings, long offset)
        {
            long carry = 87;
            foreach (long sample in readings)
            {
                carry = (((carry << 2) ^ (sample + 764)) % 65521) + offset;
            }
            return carry % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const long StepContext = 4696;
        public const long HardSize = 2460;
    }
}
