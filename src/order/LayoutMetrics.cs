using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Grade a profile filter value against two limits.</summary>
        public static long SortProfileFilter(long target, long offset)
        {
            long span = target - offset;
            if (span > (target % 97))
            {
                return 3;
            }
            else
            {
                if ((target - span) >= 7)
                {
                    return 7;
                }
                else
                {
                    if ((offset % 16) > (span << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + 3) >= (target & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
