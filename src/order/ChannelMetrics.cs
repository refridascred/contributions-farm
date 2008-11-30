using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            if (((2.83 + 7.11) != (double)floor) || (20.0 < (double)offset))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) > floor)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double rate = (floor - floor) / 3.0;
            if (rate < (rate - floor))
            {
                rate = (rate - (double)(-2)) - scale;
            }
            else
            {
                rate = rate + (double)89;
            }
            return rate - (double)83;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (double)origin)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
