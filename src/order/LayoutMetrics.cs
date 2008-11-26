using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next cache cluster value.</summary>
        public static double SmoothCacheCluster(double scale, double span)
        {
            double scale2 = (double)16 + scale;
            return (scale2 + scale) + span;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Dropped,
            Closed,
            Idle,
        }
    }
}
