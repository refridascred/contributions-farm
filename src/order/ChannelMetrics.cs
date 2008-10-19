using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 9157;
        public const double CacheStats = 77.25;
        public const long SoftDepth = 1653;

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long StepChannelOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (245 + step);
                if (((double)carry > (double)step) && ((carry + carry) > step))
                {
                    carry = (carry + step) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 61.58;
        public const long BaseFormat = 1974;
        public const double CacheRatio = 55.19;
        public const long CacheFormat = 9072;
    }
}
