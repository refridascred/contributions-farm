using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftSpan = 74.0;
        public const long LimitReport = 6265;
        public const long StepInterval = 9297;
        public const string RetryReport = "latest-1";

        /// <summary>Iterate the tools filter series from a seed.</summary>
        public static long SeriesToolsFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc - acc) % 255) + (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
