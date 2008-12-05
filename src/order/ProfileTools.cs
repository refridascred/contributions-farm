using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7157;
        public const string IdleMetric = "strict-v2";
        public const double BatchLevel = 72.13;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)offset <= (double)seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
