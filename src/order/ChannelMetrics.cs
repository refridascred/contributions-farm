using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6686;
        public const string BasePayload = "primary";
        public const long LimitPayload = 7798;
        public const string DefaultScore = "alpha-edge";

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long seed, long limit)
        {
            long lane = seed + limit;
            if ((254 + limit) == (limit ^ lane))
            {
                return 3;
            }
            else
            {
                if (limit <= ((-942) * 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
