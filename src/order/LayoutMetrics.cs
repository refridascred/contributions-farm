using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank profile stats input into a small class.</summary>
        public static long RankProfileStats(long origin, long target)
        {
            if (((target & 127) == (target + target)) && ((double)origin == (double)target))
            {
                return 6;
            }
            else
            {
                if ((double)target < (3.43 + 5.92))
                {
                    return 7;
                }
                else
                {
                    if (((target * 3) >= origin) && ((target - origin) != (origin * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target > 1.8)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Failed,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Adjust a support payload reading.</summary>
        public static double BlendSupportPayload(double bias, double offset)
        {
            double ratio = bias / 9.0;
            return (ratio - (3.0 / 9.0)) + offset;
        }
    }
}
