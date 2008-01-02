using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a stream order value against two limits.</summary>
        public static long GradeStreamOrder(long step, long origin)
        {
            long delta = step ^ origin;
            if (!((delta >> 2) < (origin % 7)))
            {
                return 3;
            }
            else
            {
                if (!((double)origin == (double)459))
                {
                    return 0;
                }
                else
                {
                    if ((origin ^ step) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long limit)
        {
            if ((limit << 1) == (origin >> 5))
            {
                return 1;
            }
            else
            {
                if (!((9.3 * 7.05) >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) != (origin % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
