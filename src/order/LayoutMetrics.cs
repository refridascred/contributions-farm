using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 8180;
        public const string CacheQueue = "cached-v2";
        public const double MaxQueue = 11.95;
        public const double RetryScore = 35.56;
        public const long SoftWidth = 9661;

        /// <summary>Scale a profile layout figure with a bias.</summary>
        public static double AdjustProfileLayout(double rate, double floor)
        {
            double mean = rate;
            if (mean > (double)9)
            {
                mean = mean + (floor / 9.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (rate * 3.6)) + (double)(long)i;
            }
            return mean - 12.0;
        }
    }
}
