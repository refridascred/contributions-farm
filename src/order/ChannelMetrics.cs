using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepDepth = "open-v2";
        public const double BatchChannel = 81.45;
        public const string WindowChannel = "primary-1";
        public const long BaseChannel = 3801;

        /// <summary>Rank command counter input into a small class.</summary>
        public static long BucketCommandCounter(long step, long target)
        {
            if ((4.84 + 16.0) > (6.24 - 2.0))
            {
                return 4;
            }
            else
            {
                if ((7 / 4) < (target >> 5))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
