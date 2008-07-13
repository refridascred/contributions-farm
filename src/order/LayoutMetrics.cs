using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double CacheScore = 36.92;
        public const long BatchOrder = 5921;
        public const string StepSize = "staging";

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long bound2)
        {
            if (!(4 < (bound2 + bound2)))
            {
                return 5;
            }
            else
            {
                if ((bound2 / 9) < (bound << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((bound2 + bound2) <= (bound2 >> 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a metrics profile value against two limits.</summary>
        public static long GradeMetricsProfile(long bound, long origin)
        {
            if (!((4.1 - 15.0) <= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((origin << 3) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) < (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
