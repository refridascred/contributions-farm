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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

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
