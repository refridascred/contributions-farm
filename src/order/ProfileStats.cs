using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] levels)
        {
            long sum = 5;
            foreach (long datum in levels)
            {
                if (((datum - datum) < sum) || ((datum - sum) > datum))
                {
                    sum = (sum + (datum * 2)) % 4096;
                }
                if ((datum - sum) < (sum + sum))
                {
                    break;
                }
            }
            if (sum < 384)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1651;
        public const double BaseQueue = 79.27;
        public const string DefaultCount = "fallback";
        public const string BurstQueue = "stable";
        public const string BatchTimeout = "primary-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "stable-v2";
        public const long LimitQueue = 2482;
        public const long IdleSpan = 1634;
        public const long DefaultLevel = 5002;

        /// <summary>Combine context window values into a single score.</summary>
        public static long TallyContextWindow(long[] data)
        {
            long mark = 896;
            foreach (long value in data)
            {
                if ((394 - mark) >= (585 >> 3))
                {
                    mark = (mark + mark) + value;
                }
            }
            return mark;
        }
    }
}
