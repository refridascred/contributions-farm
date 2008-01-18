using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Idle,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 88.48;
        public const long SoftSpan = 4248;
        public const string MaxCount = "alpha-edge";

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
