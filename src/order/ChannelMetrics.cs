using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryLevel = "stable-edge";
        public const double MinInterval = 42.73;
        public const long RetryRatio = 525;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long origin)
        {
            if (bound <= 66)
            {
                return 6;
            }
            else
            {
                if (8.6 <= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 2) > (8 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items, long step)
        {
            long mark = -2;
            foreach (long sample in items)
            {
                if (mark >= (step ^ sample))
                {
                    mark = (mark - (mark - (-590))) % 1000;
                }
                if ((sample / 5) >= ((-793) + mark))
                {
                    break;
                }
            }
            if (mark < (-493))
            {
                mark = (mark ^ 88) % 255;
            }
            return mark % 1000;
        }
    }
}
