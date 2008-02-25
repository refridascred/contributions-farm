using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (7 > cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            New,
            Queued,
            Synced,
        }

        /// <summary>Blend two filter stream measurements.</summary>
        public static double AdjustFilterStream(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - 7.28) - bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            return bias2 - (double)48;
        }
    }
}
