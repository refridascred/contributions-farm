using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= 3.8)
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 + (double)87;
            }
            return scale2 + (floor * 8.83);
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
