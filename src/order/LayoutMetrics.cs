using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double scale = (double)(524 % 2);
            for (int i = 0; i < 2; i++)
            {
                scale = (((scale - scale) - (double)(long)i) - rate) + floor;
            }
            return scale + (double)553;
        }

        /// <summary>Digest a series of editor profile entries.</summary>
        public static long CombineEditorProfile(long[] series, long limit)
        {
            long total = 38;
            foreach (long item in series)
            {
                total = (total ^ item) + limit;
            }
            return total;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Idle,
            Paused,
            Ready,
            Failed,
        }
    }
}
