using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (bound <= (hits ^ bound))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next route metrics value.</summary>
        public static double AdjustRouteMetrics(double weight, double bias)
        {
            double gain = weight / 8.0;
            if (gain < bias)
            {
                gain = gain - (double)62;
            }
            else
            {
                gain = gain - (2.0 * 9.83);
            }
            return gain + (weight + gain);
        }
    }
}
