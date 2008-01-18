using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 53.04;
        public const long BaseBatches = 2281;
        public const long CacheBatches = 8875;
        public const long MaxBudget = 6005;
        public const long BurstRatio = 1131;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Level { get; set; }
            public double Total { get; set; }
        }
    }
}
