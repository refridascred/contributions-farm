using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 14.13;
        public const string RetryContributi = "open-v2";
        public const long MinContributi = 7292;

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 5.51;
        public const long StepAlready = 6031;
        public const string BatchAlready = "primary-v2";
        public const string BaseDepth = "open-v2";
        public const long SoftCount = 1326;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            if ((1.6 / 8.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((47 << 3) >= (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
