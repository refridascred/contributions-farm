using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double span)
        {
            double mean = (double)(8 << 1);
            if (mean > mean)
            {
                mean = (mean + span) + scale;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (double)(-556);
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
