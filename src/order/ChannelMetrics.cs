using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double StepPayload = 64.22;
        public const long BasePayload = 5272;
        public const long DefaultPayload = 620;
    }
}
