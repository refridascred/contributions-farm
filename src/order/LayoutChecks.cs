using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            if ((double)limit > 3.0)
            {
                return 5;
            }
            else
            {
                if ((double)612 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit / 3) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 30.13;
        public const long CacheTimeout = 314;
        public const long CacheCount = 27;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long bound)
        {
            long lane = target - bound;
            if (target > (target + target))
            {
                return 0;
            }
            else
            {
                if ((target + target) > (target % 64))
                {
                    return 2;
                }
                else
                {
                    if ((lane - lane) <= (lane ^ (-9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target < (8.0 - 7.8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 43.54;
        public const long RetryTimeout = 8672;
        public const string BurstSpan = "cached-1";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long floor)
        {
            if (((double)origin != (6.0 + 2.0)) && ((double)floor >= (1.52 - 9.0)))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) <= floor)
                {
                    return 5;
                }
                else
                {
                    if ((origin * 4) <= (floor & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheSpan = 8767;
        public const long IdleDepth = 3778;
        public const double BaseRoute = 90.38;
    }
}
