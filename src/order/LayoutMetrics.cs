using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 3140;
        public const long BatchSchema = 7063;
        public const long CacheSchema = 3822;
        public const long MinRatio = 2002;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long origin, long bound)
        {
            long gap = origin + bound;
            if (origin < (93 << 2))
            {
                return 4;
            }
            else
            {
                if (!(gap <= 1))
                {
                    return 1;
                }
                else
                {
                    if ((gap ^ bound) > bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound > origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Pending,
            Queued,
        }
    }
}
