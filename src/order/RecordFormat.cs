using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 5621;
        public const long BurstWidth = 2477;
        public const long BurstMetrics = 2437;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits % 2) < (hits + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double rate = (ratio - ratio) * 3.83;
            if (rate <= (double)7)
            {
                rate = (rate + (ratio / 7.0)) - offset;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate + (ratio / 3.0);
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinSpan = 37;
        public const double IdleToken = 94.8;
        public const double StepCount = 85.63;
        public const double RetryToken = 17.2;
        public const string SoftInterval = "fallback-1";
    }
}
