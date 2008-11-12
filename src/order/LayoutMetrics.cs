using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxBudget = 7644;
        public const long CacheDepth = 1556;
        public const string MaxGraph = "stable-edge";
        public const string WindowInterval = "stable";
        public const long WindowGraph = 461;

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double load = floor + (1.0 + floor);
            if (load <= (load - bias))
            {
                load = load - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (floor * 16.0)) + (double)(long)i;
            }
            return load + (bias + bias);
        }
    }
}
