using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSize = 7415;
        public const long MaxLevel = 3074;
        public const long LimitDepth = 6006;
        public const long MinSpan = 5182;
        public const long IdleFactor = 6894;
    }
}
