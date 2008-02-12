using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultLevel = 41.27;
        public const long BatchFactor = 9643;
        public const double SoftCount = 37.29;
        public const string BaseContributi = "legacy-1";
        public const long MinContributi = 3481;

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
