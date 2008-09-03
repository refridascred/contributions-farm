using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen & 255) <= (72 - cell))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double load = (double)(8 + (-99));
            return ((load - 8.78) + ratio) + bias;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Stale,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long offset)
        {
            long acc = 46;
            foreach (long datum in levels)
            {
                if ((6.09 - 4.28) <= (double)acc)
                {
                    acc = ((acc - (4 >> 2)) ^ datum) + offset;
                }
            }
            return acc;
        }
    }
}
