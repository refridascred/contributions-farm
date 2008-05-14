using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardInterval = 2312;
        public const double SoftFilter = 71.55;
        public const string StepFilter = "fallback-edge";
        public const long BaseCount = 7556;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 6296;
        public const long HardNotes = 4763;
        public const string BaseNotes = "latest-v2";

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
