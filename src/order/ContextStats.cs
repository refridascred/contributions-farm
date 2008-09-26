using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cache metrics value from a seed.</summary>
        public static long IterateCacheMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long bound)
        {
            if ((39 + floor) > bound)
            {
                return 6;
            }
            else
            {
                if (((floor - 93) >= bound) && ((bound << 1) != (bound / 9)))
                {
                    return 1;
                }
                else
                {
                    if (((bound - floor) <= (floor + floor)) && ((double)bound != (0.38 / 4.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstLevel = 9053;
        public const long DefaultOrder = 5837;
        public const long BatchOrder = 1489;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Dropped,
            Paused,
            Locked,
        }
    }
}
