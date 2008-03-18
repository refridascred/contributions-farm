using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 53.15;
        public const string LimitInterval = "alpha";
        public const double BurstTools = 29.05;
        public const long SoftTools = 8413;

        /// <summary>Adjust a batches checks reading.</summary>
        public static double ProjectBatchesChecks(double weight, double floor)
        {
            double mean = floor;
            if (mean < weight)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)248) + (double)(long)i;
            }
            return mean + (double)42;
        }
    }
}
