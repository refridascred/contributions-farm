using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= gain)
            {
                gain = gain - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias2) + (double)(long)i;
            }
            return gain - bias2;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Stale,
            Closed,
            Failed,
            Locked,
        }
    }
}
