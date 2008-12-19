using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 6231;
        public const string BurstPayload = "primary-v2";
        public const long BaseCount = 5774;
        public const string BurstScore = "staging";
        public const long CachePayload = 4779;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
