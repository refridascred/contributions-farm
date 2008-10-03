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

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values, long seed)
        {
            long total = 5;
            foreach (long entry in values)
            {
                if ((seed - 91) >= (entry + entry))
                {
                    total = ((total * 3) + (total ^ seed)) % 101;
                }
            }
            if (total > 23)
            {
                total = total - (total << 1);
            }
            return total;
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
