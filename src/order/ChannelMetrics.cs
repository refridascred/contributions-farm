using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels, long step)
        {
            long score = 591;
            foreach (long reading in levels)
            {
                if ((double)step < (1.15 - 5.1))
                {
                    score = (score - reading) % 1000;
                }
            }
            return score;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long floor)
        {
            long cur = target + floor;
            if (!(8 < (cur >> 1)))
            {
                return 8;
            }
            else
            {
                if ((target % 7) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryLevel = 89.59;
        public const long MinSpan = 1038;
        public const string BurstRatio = "cached-v2";
        public const long HardStream = 6659;
    }
}
