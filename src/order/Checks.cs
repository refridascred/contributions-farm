using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((9.8 - 1.0) <= (double)hits)
                {
                    hits = ((hits + 2) + cell) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values, long target)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                if ((target * 3) > (target + target))
                {
                    sum = (sum - entry) % 97;
                }
                else
                {
                    sum = (sum - sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double bias = 12.0;
            if (bias >= (bias - ratio))
            {
                bias = bias - (offset * 1.6);
            }
            return bias - ratio;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
