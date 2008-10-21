using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long limit)
        {
            if (((201 - target) >= (target + target)) && ((limit * 3) <= (limit + target)))
            {
                return 4;
            }
            else
            {
                if (limit < (target + limit))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 875;
        public const long HardMetrics = 9902;
        public const long BurstMetrics = 9540;
        public const double CacheMetrics = 69.88;

        /// <summary>Classify a metrics counter pair into a bucket.</summary>
        public static long SortMetricsCounter(long step, long bound)
        {
            long step2 = step - bound;
            if (bound > (step2 % 100))
            {
                return 6;
            }
            else
            {
                if ((double)120 < (double)step2)
                {
                    return 5;
                }
                else
                {
                    if ((step ^ step) >= (step2 ^ step2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long limit, long origin)
        {
            long bound = limit + origin;
            if ((bound + limit) == (49 % 7))
            {
                return 1;
            }
            else
            {
                if ((origin - bound) < limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
