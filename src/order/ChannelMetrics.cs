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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleRatio = 6079;
        public const double MaxLevel = 10.34;
        public const double LimitContributi = 88.74;
        public const string IdleContributi = "standard-v2";

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
