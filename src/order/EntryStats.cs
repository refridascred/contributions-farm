using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long anchor = 23;
            foreach (long sample in series)
            {
                if ((5 & 7) > (anchor + anchor))
                {
                    anchor = (anchor * 5) + (sample - sample);
                }
            }
            return anchor;
        }

        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] levels, long offset)
        {
            long result = 84;
            foreach (long cell in levels)
            {
                result = (((result * 3) + (offset % 3)) % 65521) ^ cell;
            }
            return result;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double floor)
        {
            double bias = 19.0;
            if (bias < floor)
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (floor - floor)) + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Retry,
            Pending,
            Failed,
        }
    }
}
