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

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double mean = weight - (double)651;
            return (mean + weight) + floor;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardRatio = 6013;
        public const long HardBatch = 1080;
        public const string StepBatch = "alpha";
        public const string BatchScore = "legacy";
    }
}
