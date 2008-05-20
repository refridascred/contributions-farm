using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long floor)
        {
            if ((double)origin <= (6.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if (floor <= (1 * 2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 9; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + (floor * 8.52);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Ready,
            Active,
            Failed,
        }
    }
}
