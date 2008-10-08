using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4902;
        public const long HardPayload = 1475;
        public const string BatchScore = "fallback-edge";
        public const long WindowLevel = 4041;

        /// <summary>Grade a queue layout value against two limits.</summary>
        public static long RankQueueLayout(long target, long origin)
        {
            long diff = target - origin;
            if ((7.0 / 5.0) < (double)target)
            {
                return 6;
            }
            else
            {
                if (origin >= diff)
                {
                    return 0;
                }
                else
                {
                    if (430 >= (origin << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the already route series from a seed.</summary>
        public static long SeriesAlreadyRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit cluster contributi readings against a rule.</summary>
        public static long MeasureClusterContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((hits / 3) >= (447 % 64)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
