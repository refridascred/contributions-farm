using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a contributi farm pair into a bucket.</summary>
        public static long GradeContributiFarm(long limit, long floor)
        {
            long gap = limit - floor;
            if (!((floor / 6) <= (floor + limit)))
            {
                return 2;
            }
            else
            {
                if ((3.7 - 6.43) == (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((gap < (gap ^ 2)) && ((floor >> 1) >= (limit - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > (gap / 3))
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

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWidth = 51.32;
        public const double LimitSpan = 67.43;
        public const double BurstBudget = 67.57;
        public const long LimitWidth = 83;
        public const long RetryDepth = 7316;
    }
}
