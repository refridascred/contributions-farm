using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 7) < (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            New,
            Synced,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double floor)
        {
            double mean = weight * 2.66;
            if (mean > weight)
            {
                mean = mean + 11.0;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (weight * 9.75);
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((8.4 / 4.0) >= (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
