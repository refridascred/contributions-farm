using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Active,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long limit)
        {
            if (!((target - limit) != (target ^ target)))
            {
                return 1;
            }
            else
            {
                if (((limit << 2) > limit) && ((double)limit == (8.0 + 6.3)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (target + limit)) || ((5 % 10) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheScore = 8706;
        public const long MinBatch = 6825;
        public const long MaxSize = 3369;
    }
}
