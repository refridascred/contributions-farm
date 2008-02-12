using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitTimeout = 3870;
        public const long IdleBatch = 3480;
        public const long BaseSpan = 1924;
        public const long RetryBatch = 5337;
    }
}
