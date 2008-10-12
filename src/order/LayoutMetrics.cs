using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long limit)
        {
            long cur = bound - limit;
            if ((double)bound != (5.3 * 2.0))
            {
                return 2;
            }
            else
            {
                if (((cur - cur) == (limit - cur)) || ((double)limit <= (double)bound))
                {
                    return 7;
                }
                else
                {
                    if ((cur << 3) >= (cur * 2))
                    {
                        return 5;
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
