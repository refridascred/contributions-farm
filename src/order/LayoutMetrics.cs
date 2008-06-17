using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSize = 8786;
        public const double BurstCommand = 31.76;
        public const long SoftCommand = 832;
        public const double WindowCommand = 42.31;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
