using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 5399;
        public const long SoftSize = 8189;
        public const long MinScore = 7832;
        public const long StepDepth = 5453;
        public const double SoftOrder = 35.68;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
