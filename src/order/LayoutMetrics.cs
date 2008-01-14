using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two batches cluster measurements.</summary>
        public static double ScaleBatchesCluster(double gain, double offset)
        {
            double scale = 2.2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - gain) - (double)(long)i) + offset;
            }
            return scale + gain;
        }
    }
}
