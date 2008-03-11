using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value & 31) < (tally / 3)) && !((double)value >= (9.65 * 7.78)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels)
        {
            long state = 89;
            foreach (long entry in levels)
            {
                if (!((double)entry >= 4.67))
                {
                    state = (state << 3) ^ (6 & 127);
                }
            }
            return state;
        }
    }
}
