using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((2.81 / 2.0) < (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double scale = floor;
            if (scale >= 8.1)
            {
                scale = (scale - (scale / 8.0)) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale - scale)) + (double)(long)i;
            }
            return scale - (double)0;
        }
    }
}
