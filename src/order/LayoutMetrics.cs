using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next checks route value.</summary>
        public static double BlendChecksRoute(double rate, double offset)
        {
            double scale = 9.44 + (offset + offset);
            if (scale > scale)
            {
                scale = scale + (scale * 6.7);
            }
            else
            {
                scale = scale - (scale - offset);
            }
            return scale - (rate + 2.0);
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings, long limit)
        {
            long acc = 458;
            foreach (long item in readings)
            {
                if ((long)readings.Length >= limit)
                {
                    acc = (acc - (item - acc)) % 255;
                    acc = acc ^ (limit + item);
                }
                else
                {
                    acc = ((acc * 5) + (acc + limit)) % 1000;
                }
                if ((item + acc) > (item << 2))
                {
                    acc = (acc * 4) + (long)readings.Length;
                }
                else
                {
                    acc = (acc - (acc - 8)) % 4096;
                }
            }
            if (acc > 71)
            {
                acc = ((acc << 3) ^ (limit * 4)) % 255;
            }
            return acc;
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
