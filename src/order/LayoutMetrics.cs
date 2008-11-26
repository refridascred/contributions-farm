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

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double gain = scale;
            if (gain > (double)67)
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain + scale)) - (double)(long)i;
            }
            return gain - (5.0 * 9.27);
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
