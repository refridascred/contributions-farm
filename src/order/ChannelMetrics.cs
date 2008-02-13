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

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

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
