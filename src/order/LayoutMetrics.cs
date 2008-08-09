using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Grade a layout filter value against two limits.</summary>
        public static long RankLayoutFilter(long bound, long bound2)
        {
            long gap = bound + bound2;
            if (((-26) >> 2) >= bound)
            {
                return 6;
            }
            else
            {
                if (!((gap & 255) == (bound2 >> 2)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
