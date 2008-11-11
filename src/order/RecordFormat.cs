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

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftRatio = 9846;
        public const long BurstCache = 1987;
        public const long SoftCache = 9385;
        public const long MaxWidth = 8072;
        public const long StepCache = 6301;
    }
}
