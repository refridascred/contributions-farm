using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Failed,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Scale a checks token figure with a bias.</summary>
        public static double ProjectChecksToken(double ratio, double span)
        {
            double ratio2 = (6.7 * 2.38) / 9.0;
            return ((ratio2 + 9.0) + ratio) + span;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (7.37 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
