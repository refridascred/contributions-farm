using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((-17) < hits)
                {
                    hits = ((hits + 1) ^ item) - floor;
                }
            }
            return hits;
        }

        /// <summary>Project the next batches metric value.</summary>
        public static double AdjustBatchesMetric(double gain, double offset)
        {
            double load = (gain - offset) * 6.5;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load - gain;
        }
    }
}
