using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((reading << 3) >= reading) || (reading >= (89 / 8)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double offset)
        {
            double gain = bias;
            if (gain > (9.54 * 6.26))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 2.5) + (double)(long)i;
            }
            return gain + (gain / 4.0);
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Active,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Ready,
            Dropped,
            Draft,
            New,
        }
    }
}
