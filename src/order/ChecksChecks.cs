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

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
