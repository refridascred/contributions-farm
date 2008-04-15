using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ 864;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum - step) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long target)
        {
            if (((target + target) == (origin + origin)) && ((origin << 2) == (target << 3)))
            {
                return 1;
            }
            else
            {
                if ((origin - origin) == (target % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "alpha-v2";
        public const long WindowChannel = 1070;
        public const double CacheRatio = 76.03;
    }
}
