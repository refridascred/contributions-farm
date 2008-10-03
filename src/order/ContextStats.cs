using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if ((entry + mark) <= (mark % 97))
                {
                    mark = ((mark << 3) ^ (entry + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                long cur = mix - (long)i;
                if ((4 + cur) >= cur)
                {
                    mix = (mix ^ (68 + mix)) % 101;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "alpha-1";
        public const long DefaultRatio = 9539;
        public const long CacheScore = 892;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 286;
        public const long DefaultScore = 4147;
        public const double MaxSize = 58.26;
        public const long SoftDepth = 1284;
    }
}
