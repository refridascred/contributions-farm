using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = 2.3;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - (floor * 4.82);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 95.45;
        public const long BurstGraph = 8048;
        public const long BaseGraph = 4108;
        public const long HardBudget = 9285;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}
