using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long bound)
        {
            if (((floor * 5) < bound) && ((bound << 2) <= bound))
            {
                return 3;
            }
            else
            {
                if ((floor * 3) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound >> 3))
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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(limit > (matches ^ matches)))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= (seen / 8))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
